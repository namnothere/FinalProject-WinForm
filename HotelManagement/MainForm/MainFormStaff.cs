using FontAwesome.Sharp;
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
    public partial class MainFormStaff : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        int id;
        ACCOUNT acc = new ACCOUNT();
        
        public MainFormStaff(string username)
        {
            InitializeComponent();
            txbUsername.Text = username;
            this.id = acc.getID(username);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_sidebar.Controls.Add(leftBorderBtn);
        }

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


        private void btnSched_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFormStaff_Load(object sender, EventArgs e)
        {
            ActivateButton(btnHome, RGBcolors.color1);
            this.profilePic.Image = global::hotel_management.Properties.Resources.profileIcon;

            if (acc.getImage(txbUsername.Text) != null)
            {
                this.profilePic.Image = acc.getImage(txbUsername.Text);
            }

            txbUsername.ForeColor = Color.White;

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            OpenFormInPanel(new HomePage(this.id));
        }
    }
}
