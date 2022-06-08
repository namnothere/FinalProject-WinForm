namespace hotel_management.MainForm
{
    partial class HomePage
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbToday = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbAN = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbToday.Location = new System.Drawing.Point(440, 19);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(188, 31);
            this.lbToday.TabIndex = 1;
            this.lbToday.Text = "Today\'s Schedule";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbM.Location = new System.Drawing.Point(391, 71);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(79, 23);
            this.lbM.TabIndex = 2;
            this.lbM.Text = "Morning:";
            // 
            // lbAN
            // 
            this.lbAN.AutoSize = true;
            this.lbAN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAN.Location = new System.Drawing.Point(391, 112);
            this.lbAN.Name = "lbAN";
            this.lbAN.Size = new System.Drawing.Size(91, 23);
            this.lbAN.TabIndex = 3;
            this.lbAN.Text = "Afternoon:";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbN.Location = new System.Drawing.Point(391, 154);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(57, 23);
            this.lbN.TabIndex = 4;
            this.lbN.Text = "Night:";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 812);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbAN);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbToday);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label lbToday;
        private Label lbM;
        private Label lbAN;
        private Label lbN;
    }
}