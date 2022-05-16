using FontAwesome.Sharp;
namespace hotel_management
{
    partial class RoomManageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbReservation = new System.Windows.Forms.Label();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(154)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.lbCheckOut);
            this.panel1.Controls.Add(this.lbCheckIn);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.lbReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 47);
            this.panel1.TabIndex = 2;
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCheckOut.ForeColor = System.Drawing.Color.White;
            this.lbCheckOut.Location = new System.Drawing.Point(402, 9);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(154, 31);
            this.lbCheckOut.TabIndex = 6;
            this.lbCheckOut.Text = "Check-Out";
            this.lbCheckOut.Click += new System.EventHandler(this.lbCheckOut_Click);
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCheckIn.ForeColor = System.Drawing.Color.White;
            this.lbCheckIn.Location = new System.Drawing.Point(251, 10);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(132, 31);
            this.lbCheckIn.TabIndex = 5;
            this.lbCheckIn.Text = "Check-In";
            this.lbCheckIn.Click += new System.EventHandler(this.lbCheckIn_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(154)))), ((int)(((byte)(142)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LuggageCart;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 10);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 44);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbReservation
            // 
            this.lbReservation.AutoSize = true;
            this.lbReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbReservation.ForeColor = System.Drawing.Color.White;
            this.lbReservation.Location = new System.Drawing.Point(66, 10);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(179, 31);
            this.lbReservation.TabIndex = 3;
            this.lbReservation.Text = "Reservation ";
            this.lbReservation.Click += new System.EventHandler(this.lbReservation_Click);
            // 
            // panel_workarea
            // 
            this.panel_workarea.BackColor = System.Drawing.SystemColors.Window;
            this.panel_workarea.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel_workarea.Location = new System.Drawing.Point(0, 43);
            this.panel_workarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(1420, 807);
            this.panel_workarea.TabIndex = 3;
            // 
            // BookroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1420, 848);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookroomForm";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.BookroomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbReservation;
        private Label lbCheckIn;
        private Label lbCheckOut;
        private Panel panel_workarea;
    }
}

