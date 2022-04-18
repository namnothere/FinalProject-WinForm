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

        //MainForm frm;

        public static class FormState
        {
            public static Form PreviousPage;
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
            //MessageBox.Show("Username hoặc Password không đúng!", "Thông báo");
            //}
            FormState.PreviousPage = this;
            MainForm frm = new MainForm(this.txbUsername.Text);
            frm.FormClosed += frm_FormClosed;
            Clearfield();
            txbPassword.TabStop = false;
            frm.Show(this);
            Hide();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormState.PreviousPage.Show();
        }

        private void Clearfield()
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
        }

        private void viewPasswordbox_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar == true)
            {
                //enable password
                this.viewPasswordbox.Image = global::hotel_management.Properties.Resources.eye_slash;
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                //disable password
                txbPassword.UseSystemPasswordChar = true;
                this.viewPasswordbox.Image = global::hotel_management.Properties.Resources.eye;
            }
        }


        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }

        }


        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ngoo", "Thông báo");
        }

        private void txbUsername_MouseClick(object sender, EventArgs e)
        {
            txbPassword.TabStop = true;
        }

    }
}
