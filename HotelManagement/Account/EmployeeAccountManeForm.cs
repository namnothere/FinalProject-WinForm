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
        Form A = new ManageAccountForm();
        Form E = new EmployeeManageForm();
        string cur = "E";
        
        private void EmployeeManeForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(E);
            currForm(cur);
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
                OpenFormInPanel(A);
                cur = "A";
                currForm(cur);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (cur != "E")
            {
                OpenFormInPanel(E);
                cur = "E";
                currForm(cur);
            }
        }

        void currForm(string frm)
        {
            if (frm == "A")
            {
                btnEmployee.ForeColor = Color.White;
                btnAccount.ForeColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(147)))));
            }
            else if (frm == "E")
            {
                btnEmployee.ForeColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(147)))));
                btnAccount.ForeColor = Color.White;
            }
        }
        
    }
}
