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
        int id;
        public HomePage(int id)
        {
            InitializeComponent();
            this.id = Convert.ToInt16(id);
        }

        ATTENDANCE a = new ATTENDANCE();

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
                totalHours += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            lbHours.Text = Math.Round(totalHours, 2).ToString();
        }

    }
}
