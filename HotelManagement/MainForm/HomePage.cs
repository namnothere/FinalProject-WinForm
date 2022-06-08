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
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ForeColor = Color.Black;
            loadAttendace();
            CreateHeader();
        }

        void loadAttendace()
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
            
            dataGridView1.Columns[3].HeaderText = "Status";
            //dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns.Add("Date", "Date"); //4
            //dataGridView1.Columns[4].Visible = true;

            //dataGridView1.Columns.Add("Duration", "Duration (min)"); //5
            //dataGridView1.Columns[5].Visible = true;
            //copyStart();
        }

        //void loadDuration()
        //{
        //    DataTable table = a.getStaffAttendance(this.id);
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        TimeSpan duration = DateTime.Parse(table.Rows[i][2].ToString()) - DateTime.Parse(table.Rows[i][1].ToString());
        //        MessageBox.Show("Duration: " + Math.Round(duration.TotalMinutes, 2));
        //        dataGridView1.Rows[i].Cells["Duration"].Value = Math.Round(duration.TotalMinutes, 2).ToString();
        //    }
        //    dataGridView1.Rows[0].Cells["Duration"].Value = "1";
        //}

        //void copyStart()
        //{
        //    DataTable dt = a.getStaffAttendance(this.id);
        //    //copy value in columns 1 to columns 4
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {
        //        dataGridView1.Rows[i].Cells["Date"].Value = dt.Rows[i][1].ToString();
        //    }
        //    dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM/dd";
            

        //}

        


    }
}
