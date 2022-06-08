using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



            string username = txbUsername.Text;
            string password = txbPassword.Text;
            ACCOUNT account = new ACCOUNT(username, password);


            if (!account.usernameExist(username))
            {
                usernameExistPic.Visible = true;
                return;
            }
            
            usernameExistPic.Visible = false;

            if (account.login())
            {
                FormState.PreviousPage = this;

                if (account.admin() == 1)
                {
                    MainFormAdmin frm = new MainFormAdmin(username);
                    frm.FormClosed += frm_FormClosed;
                    frm.Show(this);
                }
                else if (account.admin() == 2)
                {
                    MainFormReceptionist frm = new MainFormReceptionist(username);
                    frm.FormClosed += frm_FormClosed;
                    frm.Show(this);
                }
                else if (account.admin() == 0)
                {
                    MainFormStaff frm = new MainFormStaff(username);
                    frm.FormClosed += frm_FormClosed;
                    frm.Show(this);
                }

                Clearfield();
                txbPassword.TabStop = false;
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            MessageBox.Show("ngoo", "Forgot Password");
        }

        private void txbUsername_MouseClick(object sender, EventArgs e)
        {
            txbPassword.TabStop = true;
        }

        private void lbNewAccount_Click(object sender, EventArgs e)
        {
            //only manager can create new account
            MessageBox.Show("Contact management to get your credentials!", "New Account");
        }
    }
}
