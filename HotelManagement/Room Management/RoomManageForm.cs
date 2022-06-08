using hotel_management.Room_Management;
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
    public partial class RoomManageForm : Form
    {
        public RoomManageForm()
        {
            InitializeComponent();
        }

        string curr = "R";

        ReservationForm R = new ReservationForm();
        CheckInForm CI = new CheckInForm();
        CheckOutForm CO = new CheckOutForm();


        private void BookroomForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(R);
            currForm(curr);
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


        void currForm(string frm)
        {
            if (frm == "R")
            {
                lbReservation.ForeColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(147)))));
                lbCheckIn.ForeColor = Color.White;
                lbCheckOut.ForeColor = Color.White;
            }
            else if (frm == "CI")
            {
                lbReservation.ForeColor = Color.White;
                lbCheckIn.ForeColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(147)))));
                lbCheckOut.ForeColor = Color.White;
            }
            else if (frm == "CO")
            {
                lbReservation.ForeColor = Color.White;
                lbCheckIn.ForeColor = Color.White;
                lbCheckOut.ForeColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(147)))));
            }
        }

        private void lbReservation_Click(object sender, EventArgs e)
        {
            if (curr != "R")
            {
                curr = "R";
                currForm(curr);
                OpenFormInPanel(R);
            }
            R.loadOrder();
            R.roombutton();
        }

        private void lbCheckIn_Click(object sender, EventArgs e)
        {
            if (curr != "CI")
            {
                curr = "CI";
                currForm(curr);
                OpenFormInPanel(CI);
            }
            CI.loadOrder();
        }

        private void lbCheckOut_Click(object sender, EventArgs e)
        {
            if (curr != "CO")
            {
                curr = "CO";
                currForm(curr);
                OpenFormInPanel(CO);
            }
        }
    }
}
