using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class HomePage : Form
    {
        int id; //id in login table
        public HomePage(int id)
        {
            InitializeComponent();
            this.id = Convert.ToInt16(id);
        }

        ATTENDANCE a = new ATTENDANCE();
        bool Locked = true; //locked "my info section", only open if user click edit the first time
        bool exist = false; //employee assign with this username is not exist
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (a.AttendanceAvailable(this.id) == false)
            {
                MessageBox.Show("You have already started your shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a.addAttendance(this.id);
            DateTime time = DateTime.Now;
            a.startShift(this.id, time);
            MessageBox.Show("You have started your shift", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadAttendace();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (a.AttendanceAvailable(this.id) != false)
            {
                MessageBox.Show("You have already ended your shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime time = DateTime.Now;
            a.endShift(this.id, time);
            MessageBox.Show("You have ended your shift", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadAttendace();
            CalculateTotalHours();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ForeColor = Color.Black;
            loadAttendace();
            CreateHeader();
            CalculateTotalHours();
            LockAllFields();
            LoadInfo();
        }

        public void loadAttendace()
        {
            DataTable dt = a.getStaffAttendance(this.id);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "ID";

            dataGridView1.Columns[1].HeaderText = "Start";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "HH:mm";
            
            dataGridView1.Columns[2].HeaderText = "End";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "HH:mm";
            
            dataGridView1.Columns[3].HeaderText = "STT";
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns[4].HeaderText = "Duration";
            dataGridView1.Columns[5].HeaderText = "Date";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "MM/dd";
        }

        void CalculateTotalHours()
        {
            double totalHours = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != DBNull.Value)
                    totalHours += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            //this is acutally total minutes so I have to convert it to hours
            lbHours.Text = "Total hours: " + Math.Round(totalHours/60, 2).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Locked && this.exist)
            {
                Locked = false;
                btnEdit.Text = "Save";
                //dataGridView1.ReadOnly = false;
                UnlockAllFields();
            }
            else
            {

                if (!this.exist) return;
                
                Locked = true;
                LockAllFields();
                btnEdit.Text = "Edit";
                
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);                

                STAFF s = new STAFF();

                DataTable table = s.getEmployeeByUsername(new ACCOUNT().getUsernameByID(this.id));

                string EmployeeID = table.Rows[0]["Id"].ToString();

                if (EmployeeID != null)
                    s.updateEmployee(EmployeeID, txbName.Text, dateTimePicker1.Value, txbAddress.Text, txbPhone.Text, comboBoxSex.SelectedItem.ToString(), txbType.Text, txbUsername.Text, pic);
                
                loadAttendace();
                CalculateTotalHours();
            }
        }

        void LockAllFields()
        {
            //lock all textbox
            txbName.ReadOnly = true;
            txbAddress.ReadOnly = true;
            txbPhone.ReadOnly = true;
            txbType.ReadOnly = true;
            txbUsername.ReadOnly = true;
            comboBoxSex.Enabled = false;
            dateTimePicker1.Enabled = false;
            pictureBox1.Enabled = false;
        }

        void UnlockAllFields()
        {
            //unlock all textbox
            txbName.ReadOnly = false;
            txbAddress.ReadOnly = false;
            txbPhone.ReadOnly = false;
            txbType.ReadOnly = false;
            txbUsername.ReadOnly = true;
            comboBoxSex.Enabled = true;
            dateTimePicker1.Enabled = true;
            pictureBox1.Enabled = true;
        }

        void LoadInfo()
        {
            //load info from database
            STAFF s = new STAFF();
            ACCOUNT acc = new ACCOUNT();
            DataTable table = s.getEmployeeByUsername(new ACCOUNT().getUsernameByID(this.id));
            if (table.Rows.Count == 0)
            {
                //MessageBox.Show("Error: Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.exist = true;
            txbName.Text = table.Rows[0]["name"].ToString();
            txbAddress.Text = table.Rows[0]["address"].ToString();
            txbPhone.Text = table.Rows[0]["phone"].ToString();
            txbType.Text = table.Rows[0]["type"].ToString();
            txbUsername.Text = table.Rows[0]["username"].ToString();
            comboBoxSex.Text = table.Rows[0]["sex"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(table.Rows[0]["dob"].ToString());

            pictureBox1.Image = acc.getImage(txbUsername.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //open dialog folder to get new image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                //picBox.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Locked && this.exist)
            {
                Locked = true;
                LoadInfo();
                LockAllFields();
                //UnlockAllFields();
            }
        }
    }
}
