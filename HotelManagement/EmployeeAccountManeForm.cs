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
    public partial class EmployeeAccountManeForm : Form
    {
        public EmployeeAccountManeForm()
        {
            InitializeComponent();
        }

        ACCOUNT acc = new ACCOUNT();

        string cur = "E";
        
        private void EmployeeManeForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new EmployeeManageForm());
        }

        private void OpenFormInPanel(object Formhijo)
        {
            if (this.panel_workarea.Controls.Count > 0)
            {
                this.panel_workarea.Controls.RemoveAt(0);
            }
            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.WindowState = FormWindowState.Normal;
            this.panel_workarea.Controls.Add(fm);
            this.panel_workarea.Tag = fm;
            fm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (cur != "A")
            {
                OpenFormInPanel(new ManageAccountForm());
                cur = "A";
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (cur != "E")
            {
                OpenFormInPanel(new EmployeeManageForm());
                cur = "E";
            }
        }
    }
}
