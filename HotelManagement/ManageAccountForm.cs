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
            lvwListAccount.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvwListAccount.Columns.Add("Username", 150, HorizontalAlignment.Center);

            DataTable accounts = acc.getAllAccounts();
            string[] arr = new string[2];
            ListViewItem item;
            //loop through all accounts and add to listview
            foreach (DataRow row in accounts.Rows)
            {

                arr[0] = row["Id"].ToString();
                arr[1] = row["Username"].ToString();

                item = new ListViewItem(arr);
                lvwListAccount.Items.Add(item);
            }
        }
    }
}
