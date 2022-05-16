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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        ORDER ord = new ORDER();
        Button currentBtn;
        bool userC = false;
        int? currentOrderID = null;

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            createTitle(LVBookList);
            CreateRoomButton(room.getAllRooms());
            loadOrder();
        }

        private Customer CreateCustomer()
        {
            Customer customer = new Customer()
            {
                id = txbID.Text,
                name = txbName.Text,
                address = txbAddress.Text,
                phone = txbPhone.Text,
                DOB = dateDOB.Value,
                sex = comboBoxSex.SelectedItem.ToString()
            };
            return customer;
        }

        private bool verif()
        {
            //return false if any of the text box is empty
            if (txbAddress.Text == "" || txbName.Text == "" || txbPhone.Text == "" || txbID.Text == "" || comboBoxSex.Text == ""
                || dateDOB.Text == "" || dBookDate.Text == "" || dClaimRoom.Text == "" || dReturnDate.Text == "")
            {
                return false;
            }
            return true;
        }


        void CreateRoomButton(DataTable table)
        {

            foreach (DataRow r in table.Rows)
            {
                Button btn;
                btn = new Button();
                btn.Width = 62;
                btn.Height = 62;
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.White;
                btn.Text = r["roomNo"].ToString();
                btn.Name = "lbl" + r["roomNo"].ToString();

                if (r["available"].ToString() == "0")
                {
                    btn.BackColor = Color.Red;
                }

                btn.Click += new EventHandler(RoomClick);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void loadOrder()
        {
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

        ListViewItem createOrderItem(order o)
        {
            ListViewItem item = new ListViewItem(o.order_id.ToString());
            item.SubItems.Add(o.order_date.ToString());
            item.SubItems.Add(o.check_in_date.ToString());
            item.SubItems.Add(o.check_out_date.ToString());
            item.SubItems.Add(o.room_id.ToString());
            item.SubItems.Add(o.customer_id.ToString());
            return item;

        }


        private void RoomClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.DarkGray)
            {
                if (currentBtn != null)
                {
                    currentBtn.BackColor = Color.DarkGray;
                }

                btn.BackColor = Color.Yellow;
                txbRoomNumber.Text = btn.Text;
                currentBtn = btn;
                userC = false;
                comboBoxRoomType.SelectedItem = room.getRoomType(Convert.ToInt32(btn.Text));
                userC = true;

            }
            else if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("This room is not available. Please choose another room", "Book Room");
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.DarkGray;
                txbRoomNumber.Text = "";
                userC = false;
                comboBoxRoomType.SelectedItem = room.getRoomType(Convert.ToInt32(btn.Text));
                userC = true;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                Customer customer = CreateCustomer();
                if (!room.roomExist(Convert.ToInt32(txbRoomNumber.Text)) || !room.getRoomStatus(Convert.ToInt32(txbRoomNumber.Text)))
                {
                    MessageBox.Show("This room is not available. Please choose another room", "Book Room");
                    return;
                }
                if (customer.CustomerExisted(txbID.Text))
                {
                    MessageBox.Show("This customer is already booked a room here", "Book Room");
                    return;
                }
                customer.RoomNumber = Convert.ToInt32(txbRoomNumber.Text);
                order o = createOrder();
                MessageBox.Show("Current order ID: " + o.order_id.ToString(), "Book Room");
                ORDER order = new ORDER();



                if (order.newBook(customer, o))
                {
                    MessageBox.Show("Booking successfull", "Book Room");
                    LVBookList.Items.Add(createOrderItem(o));
                    ClearFields();
                    flowLayoutPanel1.Controls.Clear();
                    CreateRoomButton(room.getAllRooms());
                }
                else
                {
                    MessageBox.Show("Booking failed", "Book Room");
                    flowLayoutPanel1.Controls.Clear();
                    CreateRoomButton(room.getAllRooms());
                }

            }
            else
            {
                MessageBox.Show("Please fill all the information", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }


        private order createOrder()
        {
            order o = new order()
            {
                customer_id = Convert.ToInt32(txbID.Text),
                room_id = Convert.ToInt32(txbRoomNumber.Text),
                order_date = dBookDate.Value,
                check_in_date = dClaimRoom.Value,
                check_out_date = dReturnDate.Value
            };
            ord.getLatestOrderID();
            o.order_id = ++ORDER.order_id;

            return o;
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


        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            if (txbFindRoom.Text.Trim() != "")
            {
                room r = room.getRoomByNumber(Convert.ToInt32(txbFindRoom.Text));
                if (r.roomStatus == 0)
                {
                    MessageBox.Show("This room is not available. Please choose another room", "Book Room");
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    Button btn;
                    btn = new Button();
                    btn.Width = 62;
                    btn.Height = 62;
                    btn.BackColor = Color.DarkGray;

                    btn.Text = r.roomNumber.ToString();
                    btn.Name = "lbl" + r.roomNumber.ToString();

                    btn.Click += new EventHandler(RoomClick);
                    flowLayoutPanel1.Controls.Add(btn);

                }
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userC)
            {
                string type = comboBoxRoomType.SelectedItem.ToString();
                if (room.getRoomByType(type).Rows.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    CreateRoomButton(room.getRoomByType(type));
                }
            }
        }

        private void LVBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVBookList.SelectedItems.Count > 0)
            {
                Customer c = new Customer();
                ListViewItem item = LVBookList.SelectedItems[0];
                txbRoomNumber.Text = item.SubItems[4].Text;
                txbID.Text = item.SubItems[5].Text;
                c = c.getCustomerByID(Convert.ToInt32(txbID.Text));
                txbName.Text = c.name;
                txbAddress.Text = c.address;
                txbPhone.Text = c.phone;
                comboBoxSex.SelectedItem = c.sex.ToString();
                dateDOB.Text = c.DOB.ToString();
                dBookDate.Text = item.SubItems[1].Text;
                dClaimRoom.Text = item.SubItems[2].Text;
                dReturnDate.Text = item.SubItems[3].Text;
                currentOrderID = Convert.ToInt32(item.SubItems[0].Text);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            if (currentOrderID != null)
            {
                if (!ord.orderExist((int)currentOrderID))
                {
                    MessageBox.Show("This order does not exist", "Book Room");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this order?", "Book Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ord.deleteOrder((int)currentOrderID);
                    MessageBox.Show("Delete successfully", "Book Room");
                    //currentOrderID = null;
                    ClearFields();
                    flowLayoutPanel1.Controls.Clear();
                    LVBookList.Items.Clear();
                    loadOrder();
                    CreateRoomButton(room.getAllRooms());
                }
            }
        }

        void ClearFields()
        {
            txbRoomNumber.Text = "";
            txbID.Text = "";
            txbName.Text = "";
            txbAddress.Text = "";
            txbPhone.Text = "";
            comboBoxSex.SelectedIndex = -1;
            dateDOB.Text = "";
            dBookDate.Text = "";
            dClaimRoom.Text = "";
            dReturnDate.Text = "";
            txbFindRoom.Text = "";
            comboBoxRoomType.SelectedIndex = -1;
        }

        private void dReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dReturnDate.Value < dClaimRoom.Value)
            {
                MessageBox.Show("Check-out date must be greater than check-in date", "Book Room");
                dReturnDate.Text = "";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentOrderID != null)
            {
                if (!ord.orderExist((int)currentOrderID))
                {
                    MessageBox.Show("This order does not exist", "Book Room");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this order?", "Book Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ord.updateOrder(ord.getOrderByID((int)currentOrderID));
                    MessageBox.Show("Update successfully", "Book Room");
                    //currentOrderID = null;
                    ClearFields();
                    flowLayoutPanel1.Controls.Clear();
                    LVBookList.Items.Clear();
                    loadOrder();
                    CreateRoomButton(room.getAllRooms());
                }
            }
        }
    }
}
