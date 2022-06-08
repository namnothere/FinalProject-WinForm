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
            CreateRoomButton(room.getAllRooms());
            loadOrder();
            CreateHeader();
            dataGridView1.ForeColor = Color.Black;
        }

        public void roombutton()
        {
            ROOM r = new ROOM();
            CreateRoomButton(r.getAllRooms());
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
                || dateDOB.Text == "" || dBookDate.Text == "" || dClaimRoom.Text == "" || dReturnDate.Text == ""
                || txbRoomNumber.Text == "" || comboBoxRoomType.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        bool DateValidation()
        {
            //check if the date is valid
            if (dBookDate.Value > dClaimRoom.Value || dClaimRoom.Value > dReturnDate.Value || dBookDate.Value > dReturnDate.Value)
            {
                MessageBox.Show("The date is invalid", "Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void CreateHeader()
        {
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Customer ID";
            dataGridView1.Columns[2].HeaderText = "RoomNo";
            dataGridView1.Columns[3].HeaderText = "BookDate";
            dataGridView1.Columns[4].HeaderText = "Check-in Date";
            dataGridView1.Columns[5].HeaderText = "Check-out Date";
            dataGridView1.Columns[6].HeaderText = "Total";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Status";

        }

        public void loadOrder()
        {
            DataTable table = ord.getAllReservations();
            dataGridView1.DataSource = table;


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
                if (DateValidation() == false) return;


                
                Customer customer = CreateCustomer();
                if (!room.roomExist(Convert.ToInt32(txbRoomNumber.Text)) || !room.getRoomStatus(Convert.ToInt32(txbRoomNumber.Text)))
                {
                    MessageBox.Show("This room is not available. Please choose another room", "Book Room");
                    return;
                }
                customer.RoomNumber = Convert.ToInt32(txbRoomNumber.Text);
                order o = createOrder();
                //MessageBox.Show("Current order ID: " + o.order_id.ToString(), "Book Room");
                ORDER order = new ORDER();


                if (customer.CustomerExisted(txbID.Text))
                {
                    if (order.newBook(o))
                    {
                        MessageBox.Show("Booking successfull", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadOrder();
                        userC = false;
                        ClearFields();
                        userC = true;
                        flowLayoutPanel1.Controls.Clear();
                        CreateRoomButton(room.getAllRooms());
                    }
                    else
                    {
                        MessageBox.Show("Booking failed", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (order.newBook(customer, o))
                    {
                        MessageBox.Show("Booking successful", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadOrder();
                        userC = false;
                        ClearFields();
                        userC = true;
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
                    userC = false;
                    ClearFields();
                    userC = true;
                    flowLayoutPanel1.Controls.Clear();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentOrderID != null)
            {
                if (!ord.orderExist((int)currentOrderID))
                {
                    MessageBox.Show("This order does not exist", "Book Room");
                    return;
                }

                if (!verif()) return;

                if (DateValidation() == false) return;

                if (MessageBox.Show("Are you sure you want to update this order?", "Book Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    order o = createOrder();
                    o.order_id = (int)currentOrderID;
                    o.status = "Not Paid";
                    ord.updateOrder(o);
                    MessageBox.Show("Update successfully", "Book Room");
                    userC = false;
                    ClearFields();
                    userC = true;
                    flowLayoutPanel1.Controls.Clear();
                    loadOrder();
                    CreateRoomButton(room.getAllRooms());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txbRoomNumber.Text = selectedRow.Cells[2].Value.ToString();
                txbID.Text = selectedRow.Cells[1].Value.ToString();
                string type = new ROOM().getRoomType(Convert.ToInt16(txbRoomNumber.Text));
                Customer c = new Customer();
                c = c.getCustomerByID(Convert.ToInt32(txbID.Text));
                txbName.Text = c.name;
                txbAddress.Text = c.address;
                txbPhone.Text = c.phone;
                comboBoxSex.SelectedItem = c.sex;
                userC = false;
                comboBoxRoomType.SelectedItem = type;
                userC = true;
                dateDOB.Text = c.DOB.ToString();
                dBookDate.Text = selectedRow.Cells[3].Value.ToString();
                dClaimRoom.Text = selectedRow.Cells[4].Value.ToString();
                dReturnDate.Text = selectedRow.Cells[5].Value.ToString();
                currentOrderID = Convert.ToInt32(selectedRow.Cells[0].Value);
            }


        }
    }
}
