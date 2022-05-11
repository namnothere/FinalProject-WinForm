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
    public partial class BookroomForm : Form
    {
        public BookroomForm()
        {
            InitializeComponent();
        }


        private Customer CreateCustomer()
        {
            Customer customer = new Customer()
            {
                id = txbID.Text,
                name = txbName.Text,
                address = txbAddress.Text,
                phone = txbPhone.Text,
                DOB = dateDOB.Value.ToString("dd/MM/yyyy"),
                sex = comboBoxSex.Text
            };
            return customer;
        }        

        private bool verif()
        {
            //return false if any of the text box is empty
            if (txbAddress.Text == "" || txbName.Text == "" || txbPhone.Text == "" || txbID.Text == "" || comboBoxSex.Text == ""
                || dateDOB.Text == "" || dBookDate.Text == "" || dClaimRoom.Text == "" || dReturnDate.Text == "" || txbRoom.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                Customer customer = CreateCustomer();
            }
            else
            {
                MessageBox.Show("Please fill all the information", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //foreach (BookRoom item in b.getListBookRoom())
                //{
                //    if (txtBookRoom.Text == item.id_BookRoom)
                //    {
                //        MessageBox.Show("Trùng mã đặt phòng", "Thông báo");
                //        return;
                //    }
                //}
                //foreach (var item in jBR.getNumberRoom())
                //{
                //    if (txtPhong.Text.Equals(item.sophong))
                //    {
                //        MessageBox.Show("Phòng đã có người đặt", "Thông báo");
                //        return;
                //    }
                //}

                //foreach (var item in honLoan.GetKhachHangDatPhong())
                //{
                //    if (txtCMND.Text.Equals(item.cmnd))
                //    {
                //        MessageBox.Show("Khách hàng này đã đặt phòng", "Thông Báo");
                //        return;
                //    }
                //}

            }
    }
}
