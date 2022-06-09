using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class TimeTable : Form
    {
        Schedule _schedule = new Schedule();
        STAFF _staff = new STAFF();

        public TimeTable()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            _schedule.retrieveDatabase();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DataSource = _schedule.toDataTable();

            
            listBox1.DataSource = _staff.getAllEmployees();
            listBox1.ValueMember = "name";
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _schedule.toDataTable();
            for(int i = 2; i < dt.Columns.Count; i++)
            {
                for(int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][i].ToString().Contains(listBox1.SelectedValue.ToString()))
                    {
                        dt.Rows[j][i] = listBox1.SelectedValue.ToString();
                    }
                    else
                    {
                        dt.Rows[j][i] = "";
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void labelShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _schedule.toDataTable();
        }
    }
}
