using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        string code;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtbUsername.Text.Trim() == ""))
            {
                ForgotPassword pw = new ForgotPassword();
                if (pw.existedUsername(txtbUsername.Text))
                {
                    if (txbEmail.Text.Trim() != "")
                    {
                        verifyEmail(txbEmail.Text);
                        panelCode.Visible = true;
                        panelCode.BringToFront();
                        panelNewPassword.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Email is not valid", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Username does not exist!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void verifyEmail(string rcpt)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("gurathesharkarchive@gmail.com", "wvhffsvlyckobldb"),
                EnableSsl = true,
            };
            code = RandomString(6);
            smtpClient.Send("gurathesharkarchive@gmail.com", rcpt, "Forgot Password", "Your verify code is " + code);

        }

        //generate random number
        private string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }


        private void txbEmail_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbVerify.Text.Trim() == code)
            {
                txbVerify.Text = "";
                code = RandomString(6);
                MessageBox.Show("Verify code is correct", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //panelCode.Visible = false;
                panelNewPassword.Visible = true;
                panelNewPassword.BringToFront();
            }
            else
            {
                MessageBox.Show("Invalid verify code", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelCode.Visible = false;
        }

        private void btnConfirmNewPassword_Click(object sender, EventArgs e)
        {
            ACCOUNT acc = new ACCOUNT();
            if (txbNewPassword.Text.Trim() != "")
            {
                if (acc.updateAccount(txtbUsername.Text, txbNewPassword.Text, acc.admin(txtbUsername.Text)))
                {
                    MessageBox.Show("Password changed", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ForgotPassword pw = new ForgotPassword();
                    string password = pw.Forgot(txtbUsername.Text);

                    panelNewPassword.Visible = false;
                }
                else
                    MessageBox.Show("Password not changed", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empty fields", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelNewPassword_Click(object sender, EventArgs e)
        {
            panelNewPassword.Visible = false;
            //panelCode.Visible = true;
        }

        private void txbVerify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.PerformClick();
            }
        }
    }
}
