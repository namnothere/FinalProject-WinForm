namespace hotel_management
{
    partial class ForgotPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.txbVerify = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCode = new System.Windows.Forms.Panel();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.btnCancelNewPassword = new System.Windows.Forms.Button();
            this.btnConfirmNewPassword = new System.Windows.Forms.Button();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.panelCode.SuspendLayout();
            this.panelNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbUsername.Location = new System.Drawing.Point(126, 24);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(161, 30);
            this.txtbUsername.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(100, 145);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 42);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(128, 82);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(161, 30);
            this.txbEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCode.Location = new System.Drawing.Point(22, 40);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(66, 25);
            this.lbCode.TabIndex = 2;
            this.lbCode.Text = "Code:";
            // 
            // txbVerify
            // 
            this.txbVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbVerify.Location = new System.Drawing.Point(94, 34);
            this.txbVerify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbVerify.Name = "txbVerify";
            this.txbVerify.Size = new System.Drawing.Size(161, 30);
            this.txbVerify.TabIndex = 3;
            this.txbVerify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbVerify_KeyDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(147, 112);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 44);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(27, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.panelNewPassword);
            this.panelCode.Controls.Add(this.btnCancel);
            this.panelCode.Controls.Add(this.btnConfirm);
            this.panelCode.Controls.Add(this.txbVerify);
            this.panelCode.Controls.Add(this.lbCode);
            this.panelCode.Location = new System.Drawing.Point(12, 15);
            this.panelCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(285, 172);
            this.panelCode.TabIndex = 5;
            this.panelCode.Visible = false;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.Controls.Add(this.btnCancelNewPassword);
            this.panelNewPassword.Controls.Add(this.btnConfirmNewPassword);
            this.panelNewPassword.Controls.Add(this.txbNewPassword);
            this.panelNewPassword.Controls.Add(this.lbNewPassword);
            this.panelNewPassword.Location = new System.Drawing.Point(0, 0);
            this.panelNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(278, 172);
            this.panelNewPassword.TabIndex = 9;
            this.panelNewPassword.Visible = false;
            // 
            // btnCancelNewPassword
            // 
            this.btnCancelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelNewPassword.Location = new System.Drawing.Point(27, 112);
            this.btnCancelNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelNewPassword.Name = "btnCancelNewPassword";
            this.btnCancelNewPassword.Size = new System.Drawing.Size(108, 44);
            this.btnCancelNewPassword.TabIndex = 5;
            this.btnCancelNewPassword.Text = "Cancel";
            this.btnCancelNewPassword.UseVisualStyleBackColor = true;
            this.btnCancelNewPassword.Click += new System.EventHandler(this.btnCancelNewPassword_Click);
            // 
            // btnConfirmNewPassword
            // 
            this.btnConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmNewPassword.Location = new System.Drawing.Point(147, 112);
            this.btnConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmNewPassword.Name = "btnConfirmNewPassword";
            this.btnConfirmNewPassword.Size = new System.Drawing.Size(108, 44);
            this.btnConfirmNewPassword.TabIndex = 4;
            this.btnConfirmNewPassword.Text = "Confirm";
            this.btnConfirmNewPassword.UseVisualStyleBackColor = true;
            this.btnConfirmNewPassword.Click += new System.EventHandler(this.btnConfirmNewPassword_Click);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNewPassword.Location = new System.Drawing.Point(47, 54);
            this.txbNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(187, 30);
            this.txbNewPassword.TabIndex = 3;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewPassword.Location = new System.Drawing.Point(3, 12);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(140, 25);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "New password";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 202);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panelNewPassword.ResumeLayout(false);
            this.panelNewPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox txbVerify;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Button btnCancelNewPassword;
        private System.Windows.Forms.Button btnConfirmNewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
    }
}