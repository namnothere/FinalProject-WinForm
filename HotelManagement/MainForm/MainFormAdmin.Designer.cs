using FontAwesome.Sharp;
namespace hotel_management
{
    partial class MainFormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnQLKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnRoomManagement = new FontAwesome.Sharp.IconButton();
            this.btnSched = new FontAwesome.Sharp.IconButton();
            this.btnStaffMane = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.panel_sidebar.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel_sidebar.Controls.Add(this.btnLogout);
            this.panel_sidebar.Controls.Add(this.btnDangXuat);
            this.panel_sidebar.Controls.Add(this.btnQLKhachHang);
            this.panel_sidebar.Controls.Add(this.btnRoomManagement);
            this.panel_sidebar.Controls.Add(this.btnSched);
            this.panel_sidebar.Controls.Add(this.btnStaffMane);
            this.panel_sidebar.Controls.Add(this.btnHome);
            this.panel_sidebar.Controls.Add(this.panelInfo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(292, 833);
            this.panel_sidebar.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 489);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnLogout.Size = new System.Drawing.Size(292, 60);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 549);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(292, 284);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQLKhachHang.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnQLKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 426);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(292, 63);
            this.btnQLKhachHang.TabIndex = 13;
            this.btnQLKhachHang.Text = "Client Management";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnRoomManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomManagement.FlatAppearance.BorderSize = 0;
            this.btnRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoomManagement.ForeColor = System.Drawing.Color.White;
            this.btnRoomManagement.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnRoomManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRoomManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoomManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomManagement.Location = new System.Drawing.Point(0, 366);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnRoomManagement.Size = new System.Drawing.Size(292, 60);
            this.btnRoomManagement.TabIndex = 12;
            this.btnRoomManagement.Text = "Room Management";
            this.btnRoomManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomManagement.UseVisualStyleBackColor = false;
            this.btnRoomManagement.Click += new System.EventHandler(this.btnRoomManagement_Click);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSched.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSched.FlatAppearance.BorderSize = 0;
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSched.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSched.ForeColor = System.Drawing.Color.White;
            this.btnSched.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnSched.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSched.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSched.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSched.Location = new System.Drawing.Point(0, 306);
            this.btnSched.Name = "btnSched";
            this.btnSched.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnSched.Size = new System.Drawing.Size(292, 60);
            this.btnSched.TabIndex = 11;
            this.btnSched.Text = "Schedule";
            this.btnSched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnStaffMane
            // 
            this.btnStaffMane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnStaffMane.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffMane.FlatAppearance.BorderSize = 0;
            this.btnStaffMane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffMane.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStaffMane.ForeColor = System.Drawing.Color.White;
            this.btnStaffMane.IconChar = FontAwesome.Sharp.IconChar.LuggageCart;
            this.btnStaffMane.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStaffMane.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffMane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffMane.Location = new System.Drawing.Point(0, 246);
            this.btnStaffMane.Name = "btnStaffMane";
            this.btnStaffMane.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnStaffMane.Size = new System.Drawing.Size(292, 60);
            this.btnStaffMane.TabIndex = 10;
            this.btnStaffMane.Text = "Staff Management";
            this.btnStaffMane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffMane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffMane.UseVisualStyleBackColor = false;
            this.btnStaffMane.Click += new System.EventHandler(this.btnStaffMane_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 179);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnHome.Size = new System.Drawing.Size(292, 67);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.txbUsername);
            this.panelInfo.Controls.Add(this.profilePic);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(292, 179);
            this.panelInfo.TabIndex = 8;
            // 
            // txbUsername
            // 
            this.txbUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbUsername.Location = new System.Drawing.Point(0, 152);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(290, 25);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.Text = "label1";
            this.txbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePic
            // 
            this.profilePic.Image = global::hotel_management.Properties.Resources.profileIcon;
            this.profilePic.Location = new System.Drawing.Point(68, -1);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(150, 150);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // panel_workarea
            // 
            this.panel_workarea.BackColor = System.Drawing.Color.Gray;
            this.panel_workarea.Location = new System.Drawing.Point(292, 0);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(1406, 859);
            this.panel_workarea.TabIndex = 18;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1697, 833);
            this.ControlBox = false;
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel_sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_sidebar;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnRoomManagement;
        private FontAwesome.Sharp.IconButton btnSched;
        private FontAwesome.Sharp.IconButton btnStaffMane;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelInfo;
        private PictureBox profilePic;
        private IconButton btnQLKhachHang;
        private IconButton btnLogout;
        private Label txbUsername;
        private Panel panel_workarea;
    }
}