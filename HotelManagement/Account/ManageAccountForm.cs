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
            lvwListAccount.Items.Clear();
            lvwListAccount.Columns.Clear();
            lvwListAccount.Columns.Add("ID", 70, HorizontalAlignment.Center);
            lvwListAccount.Columns.Add("Username", 150, HorizontalAlignment.Center);

            DataTable accounts = acc.getAllAccounts();
            string[] arr = new string[2];
            ListViewItem item;
            lvwListAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //loop through all accounts and add to listview
            foreach (DataRow row in accounts.Rows)
            {

                arr[0] = row["Id"].ToString();
                arr[1] = row["Username"].ToString();

                item = new ListViewItem(arr);
                lvwListAccount.Items.Add(item);
            }
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
            if (acc.insertAccount(txbUsername.Text, txbPassword.Text))
            {
                MessageBox.Show("Account created", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to create account", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadListView();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!verif())
                return;
            
            if (!acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("Username does not exist", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc.updateAccount(txbUsername.Text, txbPassword.Text))
            {
                MessageBox.Show("Password updated", "Update password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update password", "Update password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadListView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!verif())
                return;
            
            if (!acc.usernameExist(txbUsername.Text))
            {
                MessageBox.Show("Username does not exist", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (acc.deleteAccount(txbUsername.Text))
            {
                MessageBox.Show("Account deleted", "Delete account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
