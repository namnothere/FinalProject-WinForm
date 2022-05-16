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
            createTitle(LVBookList);
            loadOrder();
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

        private void createTitle(ListView lvwBookRoomList)
        {
            lvwBookRoomList.Columns.Add("Order ID", 90);
            lvwBookRoomList.Columns.Add("Reservation", 115);
            lvwBookRoomList.Columns.Add("Check-in", 95);
            lvwBookRoomList.Columns.Add("Check-out", 110);
            lvwBookRoomList.Columns.Add("RoomNo", 100);
            lvwBookRoomList.Columns.Add("CID", 60);

            lvwBookRoomList.View = View.Details;
        }


        private void LVBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVBookList.CheckedItems.Count > 0)
            {
                Customer c = new Customer();
                ListViewItem item = LVBookList.SelectedItems[0];
                c = c.getCustomerByID(Convert.ToInt32(txbID.Text));
                txbID.Text = item.SubItems[5].Text;
                txbName.Text = c.name;
                txbAddress.Text = c.address;
                txbPhone.Text = c.phone;
                comboBoxSex.SelectedItem = c.sex.ToString();
                dateDOB.Text = c.DOB.ToString();
                
                txbRoomNumber.Text = item.SubItems[4].Text;
                dBookDate.Text = item.SubItems[1].Text;
                dClaimRoom.Text = item.SubItems[2].Text;
                currentOrderID = Convert.ToInt32(item.SubItems[0].Text);
                txbStatus.Text = item.SubItems[3].Text;
            }
        }

        void loadOrder()
        {
            ORDER ord = new ORDER();
            DataTable table = ord.getAllOrders();
            foreach (DataRow r in table.Rows)
            {
                ListViewItem item = new ListViewItem(r["ID"].ToString());
                item.SubItems.Add(r["dCreate"].ToString());
                item.SubItems.Add(r["dCheckIn"].ToString());
                item.SubItems.Add(r["dCheckOut"].ToString());
                item.SubItems.Add(r["RoomNumber"].ToString());
                item.SubItems.Add(r["CID"].ToString());

                LVBookList.Items.Add(item);
            }

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }
    }


    
}
