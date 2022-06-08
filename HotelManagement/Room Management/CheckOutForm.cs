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
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        int OrderID;
        DISCOUNT d = new DISCOUNT();
        ORDER o = new ORDER();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            CheckIn_List frm = new CheckIn_List();
            frm.Show();
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
        }


        //get form tag when form is closing
        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f = (Form)sender;
            if (f.Tag != null)
            {
                this.OrderID = Convert.ToInt16(f.Tag);
                LoadOrder();
            }
        }

        void LoadOrder()
        {
            //load order
            ORDER ord = new ORDER();
            DataTable dt = new DataTable();
            order o = ord.getOrderByID(this.OrderID);


            ROOM Room = new ROOM();
            room r = Room.getRoomByNumber(Convert.ToInt16(o.room_id.ToString()));
            
            ClearFields();
            
            lbTransID.Text = o.order_id.ToString();
            txbClient.Text = o.customer_id.ToString();
            txbRoomNo.Text = o.room_id.ToString();
            txbCheckInDate.Text = o.check_in_date.ToString("MM/dd/yyyy");
            txbCheckOutDate.Text = o.check_out_date.ToString("MM/dd/yyyy");
            txbRoomType.Text = r.roomType;
            txbRoomRate.Text = r.roomPrice.ToString();
            txbDays.Text = (o.check_out_date - o.check_in_date).Days.ToString();
            
            LockFields();
            BillCalculate();

        }

        void BillCalculate()
        {
            int days = Convert.ToInt16(txbDays.Text);
            int roomRate = Convert.ToInt16(txbRoomRate.Text);
            int discount = Convert.ToInt16(comboBoxDiscount.SelectedValue);
            int total = days * roomRate;
            int discountRate = (total * discount) / 100;
            int netTotal = total - discountRate;


            txbSubtotal.Text = total.ToString();
            txbTotal.Text = netTotal.ToString();
        }

        void ClearFields()
        {
            lbTransID.Text = "";
            txbClient.Text = "";
            txbRoomNo.Text = "";
            txbCheckInDate.Text = "";
            txbCheckOutDate.Text = "";
            txbRoomType.Text = "";
            txbRoomRate.Text = "";
            txbDays.Text = "";
            txbTotal.Text = "";
            txbSubtotal.Text = "";
            comboBoxDiscount.SelectedIndex = -1;
        }

        void LoadDiscount()
        {
            DataTable dt = new DataTable();
            dt = d.getAllDiscounts();
            dataGridView1.DataSource = dt;
        }

        void LoadComboBox()
        {
            DataTable dt = new DataTable();
            dt = d.getAllDiscounts();
            comboBoxDiscount.DataSource = dt;
            comboBoxDiscount.DisplayMember = "Type";
            comboBoxDiscount.ValueMember = "Rate";
            comboBoxDiscount.SelectedIndex = -1;
        }
        

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Type";
            dataGridView1.Columns[2].HeaderText = "Rate";
        }
        

        bool DiscountAvailable()
        {
            if (txbDRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter discount rate", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToInt16(txbDRate.Text) > 100 || Convert.ToInt16(txbDRate.Text) < 0)
            {
                MessageBox.Show("Discount rate cannot be greater than 100% or less than 0%", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if discount rate is not int
            if (!int.TryParse(txbDRate.Text, out int result))
            {
                MessageBox.Show("Discount rate must be a number", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DiscountAvailable())
            {
                if (d.DiscountHandle(txbDName.Text, Convert.ToInt16(txbDRate.Text)))
                {
                    MessageBox.Show("Discount update successfully", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDiscount();
                    BillCalculate();
                }
                else
                {
                    MessageBox.Show("Discount is not updated", "Discout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DiscountAvailable())
            {
                if (d.removeDiscount(txbDName.Text))
                {
                    MessageBox.Show("Discount removed successfully", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDiscount();
                }
                else
                {
                    MessageBox.Show("Discount is not removed", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LockFields()
        {
            txbCheckInDate.Enabled = false;
            txbCheckOutDate.Enabled = false;
            txbClient.Enabled = false;
            txbRoomNo.Enabled = false;
            txbRoomRate.Enabled = false;
            txbRoomType.Enabled = false;
            txbTotal.Enabled = false;
            txbSubtotal.Enabled = false;
            txbDays.Enabled = false;
        }
        
        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            LoadDiscount();
            LoadComboBox();
            dataGridView1.ForeColor = Color.Black;
            CreateHeader();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbDName.Text = row.Cells["Type"].Value.ToString();
                txbDRate.Text = row.Cells["Rate"].Value.ToString();
            }
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiscount.SelectedIndex >= 0 && lbTransID.Text != "")
                BillCalculate();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // ask if user want to reserve room
            DialogResult result = MessageBox.Show("Do you want to reserve this room?", "Reserve", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (o.Paid(Convert.ToInt16(lbTransID.Text)))
                {
                    MessageBox.Show("Paid and check out successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Order is not paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully print out bill!", "Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
