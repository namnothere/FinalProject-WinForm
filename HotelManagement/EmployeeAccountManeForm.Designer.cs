namespace hotel_management
{
    partial class EmployeeAccountManeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgAvatar = new System.Windows.Forms.ImageList(this.components);
            this.panel_workarea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.Window;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAccount.Location = new System.Drawing.Point(141, 29);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(114, 35);
            this.btnAccount.TabIndex = 24;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEmployee.Location = new System.Drawing.Point(21, 29);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(114, 35);
            this.btnEmployee.TabIndex = 25;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 64);
            this.panel1.TabIndex = 22;
            // 
            // imgAvatar
            // 
            this.imgAvatar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgAvatar.ImageSize = new System.Drawing.Size(16, 16);
            this.imgAvatar.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel_workarea
            // 
            this.panel_workarea.Location = new System.Drawing.Point(0, 69);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(1252, 523);
            this.panel_workarea.TabIndex = 23;
            // 
            // EmployeeAccountManeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1252, 590);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeAccountManeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeManeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider errorProvider1;
        private Panel panel_workarea;
        private Panel panel1;
        private Button btnEmployee;
        private Button btnAccount;
        private ImageList imgAvatar;
    }
}