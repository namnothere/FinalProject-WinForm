using FontAwesome.Sharp;
namespace hotel_management
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usernameExistPic = new System.Windows.Forms.PictureBox();
            this.lbNewAccount = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.viewPasswordbox = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.UsernametoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameExistPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.usernameExistPic);
            this.groupBox1.Controls.Add(this.lbNewAccount);
            this.groupBox1.Controls.Add(this.lbForgotPassword);
            this.groupBox1.Controls.Add(this.viewPasswordbox);
            this.groupBox1.Controls.Add(this.lbExit);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txbUsername);
            this.groupBox1.Controls.Add(this.txbPassword);
            this.groupBox1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(300, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // usernameExistPic
            // 
            this.usernameExistPic.BackColor = System.Drawing.Color.Transparent;
            this.usernameExistPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameExistPic.ErrorImage = null;
            this.usernameExistPic.Image = global::hotel_management.Properties.Resources.RedXbutton;
            this.usernameExistPic.Location = new System.Drawing.Point(285, 97);
            this.usernameExistPic.Name = "usernameExistPic";
            this.usernameExistPic.Size = new System.Drawing.Size(28, 24);
            this.usernameExistPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernameExistPic.TabIndex = 6;
            this.usernameExistPic.TabStop = false;
            this.UsernametoolTip.SetToolTip(this.usernameExistPic, "Username does not exist");
            this.usernameExistPic.Visible = false;
            // 
            // lbNewAccount
            // 
            this.lbNewAccount.AutoSize = true;
            this.lbNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNewAccount.ForeColor = System.Drawing.Color.Black;
            this.lbNewAccount.Location = new System.Drawing.Point(6, 219);
            this.lbNewAccount.Name = "lbNewAccount";
            this.lbNewAccount.Size = new System.Drawing.Size(117, 20);
            this.lbNewAccount.TabIndex = 4;
            this.lbNewAccount.Text = "New account";
            this.lbNewAccount.Click += new System.EventHandler(this.lbNewAccount_Click);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.lbForgotPassword.Location = new System.Drawing.Point(154, 219);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(159, 20);
            this.lbForgotPassword.TabIndex = 2;
            this.lbForgotPassword.Text = "Forgot password?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // viewPasswordbox
            // 
            this.viewPasswordbox.BackColor = System.Drawing.Color.Transparent;
            this.viewPasswordbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPasswordbox.ErrorImage = null;
            this.viewPasswordbox.Image = global::hotel_management.Properties.Resources.eye;
            this.viewPasswordbox.Location = new System.Drawing.Point(285, 182);
            this.viewPasswordbox.Name = "viewPasswordbox";
            this.viewPasswordbox.Size = new System.Drawing.Size(28, 24);
            this.viewPasswordbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPasswordbox.TabIndex = 2;
            this.viewPasswordbox.TabStop = false;
            this.viewPasswordbox.Click += new System.EventHandler(this.viewPasswordbox_Click);
            // 
            // lbExit
            // 
            this.lbExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbExit.Location = new System.Drawing.Point(116, 325);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(91, 42);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "Exit";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(46, 275);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUsername.Location = new System.Drawing.Point(46, 94);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PlaceholderText = "Username";
            this.txbUsername.Size = new System.Drawing.Size(233, 30);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.TabStop = false;
            this.txbUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbUsername_MouseClick);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(46, 178);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PlaceholderText = "Password";
            this.txbPassword.Size = new System.Drawing.Size(233, 30);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.TabStop = false;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel_management.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 631);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameExistPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PictureBox viewPasswordbox;
        private Label lbForgotPassword;
        private Label lbNewAccount;
        private System.ComponentModel.IContainer components;
        private PictureBox usernameExistPic;
        private ToolTip UsernametoolTip;
    }
}