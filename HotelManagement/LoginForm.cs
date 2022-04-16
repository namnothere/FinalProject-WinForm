using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class LoginForm : Form
    {
        //private clsAccount qlAccount = new clsAccount();
        //public Account account;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //account = new Account()
            //{
            //    username = txtUsername.Text.ToUpper(),
            //    password = txtPassword.Text
            //};

            //if (qlAccount.CheckAccount(account))
            //{
            //    this.DialogResult = DialogResult.Yes;
            //}
            //else
            //{
                MessageBox.Show("Username hoặc Password không đúng!", "Thông báo");
            //}
        }

        private void txbUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txbUsername.Text = "";
            //((TextBox)sender).Text = "";
        }

        private void txbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txbPassword.Text = "";
        }

        private void viewPasswordbox_Click(object sender, EventArgs e)
        {
            if (txbPassword.PasswordChar == '*')
            {
                this.viewPasswordbox.Image = global::hotel_management.Properties.Resources.eye_slash;
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                this.viewPasswordbox.Image = global::hotel_management.Properties.Resources.eye;
                txbPassword.PasswordChar = '*';
            }
        }

        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '*';
            }
        }

        private void txbUsername_MouseLeave(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                txbUsername.Text = "Username";
            }
        }
    }
}
