using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management.Room_Management
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        ORDER o = new ORDER();

        private void History_Load(object sender, EventArgs e)
        {
            DataTable table = o.getAllOrders();
            dataGridView1.DataSource = table;
            dataGridView1.ForeColor = Color.Black;
            CreateHeader();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataTable table = o.getAllOrders();
            dataGridView1.DataSource = table;
        }

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Customer ID";
            dataGridView1.Columns[2].HeaderText = "Room ID";
            
            dataGridView1.Columns[3].HeaderText = "Reservation";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dataGridView1.Columns[4].HeaderText = "Check In";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dataGridView1.Columns[5].HeaderText = "Check Out";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";     
            
            dataGridView1.Columns[6].HeaderText = "Total Price";
            dataGridView1.Columns[7].HeaderText = "Discount";
            dataGridView1.Columns[8].HeaderText = "Status";
            dataGridView1.Columns[9].HeaderText = "Note";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text.Trim() != "")
            {
                //check is txb is int
                if (int.TryParse(txbSearch.Text, out int result))
                {
                    DataTable table = o.searchByOrderID(Convert.ToInt16(txbSearch.Text));
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
