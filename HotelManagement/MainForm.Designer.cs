using FontAwesome.Sharp;
namespace hotel_management
{
    partial class MainForm
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
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnQLKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnTraPhong = new FontAwesome.Sharp.IconButton();
            this.btnNhanPhong = new FontAwesome.Sharp.IconButton();
            this.btnDatPhong = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.panel_sidebar.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_sidebar.Controls.Add(this.btnDangXuat);
            this.panel_sidebar.Controls.Add(this.btnQLKhachHang);
            this.panel_sidebar.Controls.Add(this.btnTraPhong);
            this.panel_sidebar.Controls.Add(this.btnNhanPhong);
            this.panel_sidebar.Controls.Add(this.btnDatPhong);
            this.panel_sidebar.Controls.Add(this.btnHome);
            this.panel_sidebar.Controls.Add(this.panelInfo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(292, 545);
            this.panel_sidebar.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 485);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(292, 60);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQLKhachHang.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnQLKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 427);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(292, 60);
            this.btnQLKhachHang.TabIndex = 13;
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTraPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnTraPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTraPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTraPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.Location = new System.Drawing.Point(0, 367);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnTraPhong.Size = new System.Drawing.Size(292, 60);
            this.btnTraPhong.TabIndex = 12;
            this.btnTraPhong.Text = "Check-in/out";
            this.btnTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNhanPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanPhong.FlatAppearance.BorderSize = 0;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanPhong.ForeColor = System.Drawing.Color.White;
            this.btnNhanPhong.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnNhanPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanPhong.Location = new System.Drawing.Point(0, 307);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnNhanPhong.Size = new System.Drawing.Size(292, 60);
            this.btnNhanPhong.TabIndex = 11;
            this.btnNhanPhong.Text = "Lịch làm việc";
            this.btnNhanPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.IconChar = FontAwesome.Sharp.IconChar.LuggageCart;
            this.btnDatPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(0, 247);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(292, 60);
            this.btnDatPhong.TabIndex = 10;
            this.btnDatPhong.Text = "Quản lý nhân viên";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 168);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.btnHome.Size = new System.Drawing.Size(292, 79);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.txbUsername);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(292, 168);
            this.panelInfo.TabIndex = 8;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Enabled = false;
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txbUsername.Location = new System.Drawing.Point(-1, 141);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(292, 23);
            this.txbUsername.TabIndex = 2;
            this.txbUsername.TabStop = false;
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_management.Properties.Resources.profileIcon;
            this.pictureBox1.Location = new System.Drawing.Point(59, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_workarea
            // 
            this.panel_workarea.BackColor = System.Drawing.Color.LightGray;
            this.panel_workarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workarea.Location = new System.Drawing.Point(292, 0);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(808, 545);
            this.panel_workarea.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Quản lý khách sạn - Nhân viên: sadio mane";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panel_workarea;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnQLKhachHang;
        private FontAwesome.Sharp.IconButton btnTraPhong;
        private FontAwesome.Sharp.IconButton btnNhanPhong;
        private FontAwesome.Sharp.IconButton btnDatPhong;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelInfo;
        private PictureBox pictureBox1;
        private TextBox txbUsername;
    }
}