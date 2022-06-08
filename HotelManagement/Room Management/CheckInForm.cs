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
    public partial class CheckInForm : Form
    {
        int currentOrderID;
        
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            loadOrder();
            CreateHeader();
            dataGridView1.ForeColor = Color.Black;
        }

        void AutoComplete()
        {

            Customer c = new Customer();
            DataTable table = c.getAllCustomers();
            txbSearch.AutoCompleteCustomSource.Clear();
            if (rbID.Checked)
            {
                foreach (DataRow r in table.Rows)
                {
                    txbSearch.AutoCompleteCustomSource.Add(r["ID"].ToString());
                }

            }
            else
            {
                foreach (DataRow r in table.Rows)
                {
                    txbSearch.AutoCompleteCustomSource.Add(r["Name"].ToString());
                }
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete();
        }

        
        public void loadOrder()
        {
            ORDER ord = new ORDER();
            DataTable table = ord.getAllReservations();
            dataGridView1.DataSource = table;

        }

        void ClearFields()
        {

            txbSearch.Text = "";
            txbRoomNumber.Text = "";
            txbAddress.Text = "";
            txbID.Text = "";
            txbName.Text = "";
            txbNote.Text = "";
            txbPhone.Text = "";
            txbStatus.Text = "";
            comboBoxRoomType.SelectedIndex = -1;
            comboBoxSex.SelectedIndex = -1;
            
        }

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "CID";
            dataGridView1.Columns[2].HeaderText = "RoomNo";
            dataGridView1.Columns[3].HeaderText = "Reservation";
            dataGridView1.Columns[4].HeaderText = "Check-in";
            dataGridView1.Columns[5].HeaderText = "Check-out";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Status";
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            ORDER o = new ORDER();
            if (!o.addNote(currentOrderID, txbNote.Text))
            {
                MessageBox.Show("Can not add note to this order", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            o.checkIn(currentOrderID);
            MessageBox.Show("Check in successfully", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            loadOrder();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            currentOrderID = int.Parse(row.Cells[0].Value.ToString());
            txbID.Text = row.Cells[1].Value.ToString();
            txbRoomNumber.Text = row.Cells[2].Value.ToString();
            dBookDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            dClaimRoom.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            txbNote.Text = row.Cells[6].Value.ToString();
            txbStatus.Text = row.Cells[8].Value.ToString();


            string type = new ROOM().getRoomType(Convert.ToInt16(txbRoomNumber.Text));
            Customer c = new Customer().getCustomerByID(Convert.ToInt16(row.Cells[1].Value));
            txbName.Text = c.name;
            txbPhone.Text = c.phone;
            txbAddress.Text = c.address;
            comboBoxSex.SelectedItem = c.sex;
            dateDOB.Value = c.DOB;
            comboBoxRoomType.SelectedItem = type;


        }
    }


    
}
