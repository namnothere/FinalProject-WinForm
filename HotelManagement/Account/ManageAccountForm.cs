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
    public partial class ManageAccountForm : Form
    {
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        ACCOUNT acc = new ACCOUNT();

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {
            loadListView();
        }

        private void loadListView()
        {
            //dataListAccount
            this.dataListAccount.DataSource = null;
            dataListAccount.Refresh();
            DataTable accounts = acc.getAllAccounts();

            dataListAccount.ForeColor = Color.Black;
            dataListAccount.DataSource = accounts;


            dataListAccount.Columns[0].HeaderText = "ID";
            dataListAccount.Columns[1].HeaderText = "Username";
            dataListAccount.Columns[2].HeaderText = "Perms";
            dataListAccount.Columns[2].Visible = false;
            dataListAccount.Columns[3].HeaderText = "Password";
            dataListAccount.Columns[3].Visible = false;
            

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!verif())
                return;
            
            if (acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("Username already exists", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.insertAccount(txbUsername.Text, txbPassword.Text, perm()))
            {
                MessageBox.Show("Account created", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListView();
            }
            else
            {
                MessageBox.Show("Failed to create account", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int perm()
        {
            //Admin: 1
            //Recept: 2
            //Staff: 0
            
            if (cbAdmin.Checked && cbRecept.Checked)
                return 1;
            else if (cbRecept.Checked)
                return 2;
            else
                return 0;
            
        }


        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!verif())
                return;
            //if (acc.Available(txbUsername.Text, acc.getID(txbUsername.Text)) == false)
            //{
            //    MessageBox.Show("Username not available", "Update account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (!acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("Username does not exist", "Update account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.updateAccount(txbUsername.Text, txbPassword.Text, perm()))
            {
                MessageBox.Show("Successfully updated", "Update account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update", "Update account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadListView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text.Trim() == "")
                return;
            
            if (!acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("Username does not exist", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (acc.deleteAccount(txbUsername.Text))
            {
                MessageBox.Show("Account deleted", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListView();
            }
            else
            {
                MessageBox.Show("Failed to delete account", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadListView();
        }

        private bool verif()
        {
            if (txbUsername.Text == "")
            {
                MessageBox.Show("Username is required", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbPassword.Text == "")
            {
                MessageBox.Show("Password is required", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

       

        private void dataListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                return;
            DataGridViewRow row = dataListAccount.Rows[index];
            txbUsername.Text = row.Cells[1].Value.ToString();
            txbPassword.Text = row.Cells[3].Value.ToString();
            if (row.Cells[2].Value.ToString() == "1")
            {
                cbAdmin.Checked = true;
                cbRecept.Checked = true;
            }
            else if (row.Cells[2].Value.ToString() == "2")
            {
                cbRecept.Checked = true;
                cbAdmin.Checked = false;
            }
            else
            {
                cbAdmin.Checked = false;
                cbRecept.Checked = false;
            }

        }
    }
}
