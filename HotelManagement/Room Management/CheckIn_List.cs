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
    public partial class CheckIn_List : Form
    {
        public CheckIn_List()
        {
            InitializeComponent();
        }

        private void CheckIn_List_Load(object sender, EventArgs e)
        {
            loadOrder();
            CreateHeader();
        }

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "CID";
            dataGridView1.Columns[2].HeaderText = "RoomNo";
            dataGridView1.Columns[3].HeaderText = "Reservation";
            dataGridView1.Columns[4].HeaderText = "Check-in";
            dataGridView1.Columns[5].HeaderText = "Check-out";
        }


        void loadOrder()
        {
            ORDER ord = new ORDER();
            DataTable table = ord.getAllCheckedIn();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get selected cell
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                this.Tag = dataGridView1.Rows[index].Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search using concat
            if (txbSearch.Text.Trim() != "")
            {
                ORDER o = new ORDER();

                //check if search is int 
                if (int.TryParse(txbSearch.Text, out int result))
                {
                    //search by id
                    DataTable table = o.searchOrderbyRoom(Convert.ToInt16(txbSearch.Text));
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
