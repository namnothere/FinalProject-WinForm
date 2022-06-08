#nullable enable // at the top of the file
using FontAwesome.Sharp;
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
    public partial class MainFormAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //private Account account;

        int id;
        public MainFormAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_sidebar.Controls.Add(leftBorderBtn);
        }

        public static class FormState
        {
            public static Form PreviousPage;
        }

        //public frmMain(Account account)
        //{
        //    InitializeComponent();
        //    leftBorderBtn = new Panel();
        //    leftBorderBtn.Size = new Size(7, 60);
        //    panel_sidebar.Controls.Add(leftBorderBtn);
        //    this.account = account;
        //}

        public MainFormAdmin(string username)
        {
            InitializeComponent();
            ACCOUNT acc = new ACCOUNT();
            this.id = acc.getID(username);
            txbUsername.Text = username;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_sidebar.Controls.Add(leftBorderBtn);
        }

        //struct
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(254, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 241);
            public static Color color6 = Color.FromArgb(24, 165, 241);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DissableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DissableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 55, 55);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ActivateButton(btnHome, RGBcolors.color1);
            this.profilePic.Image = global::hotel_management.Properties.Resources.profileIcon;
            ACCOUNT acc = new ACCOUNT();

            //pic = (byte[])acc.getImage(txbUsername.Text);
            //MemoryStream picture = new MemoryStream(pic);

            if (acc.getImage(txbUsername.Text) != null)
            {
                this.profilePic.Image = acc.getImage(txbUsername.Text);
            }

            txbUsername.ForeColor = Color.White;

            //this.profilePic.Image = global::hotel_management.Properties.Resources.profileIcon;
            //var ST = new clsStaff();
            //var nv = ST.CheckIfExist(account.username);
            //lblName.Text = nv.name;
        }

        private void OpenFormInPanel(object Formhijo)
        {
            this.panel_workarea.Controls.Clear();
            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            //fm.WindowState = FormWindowState.Normal;
            this.panel_workarea.Controls.Add(fm);
            this.panel_workarea.Tag = fm;
            fm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            FormState.PreviousPage = this;
            OpenFormInPanel(new HomePage(this.id));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);

            //OpenFormInPanel(new frmCheckIn());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
            //OpenFormInPanel(new frmCustomerManagement());
        }

        private void btnStaffMane_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            FormState.PreviousPage = this;
            OpenFormInPanel(new EmployeeAccountManeForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            OpenFormInPanel(new RoomManageForm());
        }
    }
}
