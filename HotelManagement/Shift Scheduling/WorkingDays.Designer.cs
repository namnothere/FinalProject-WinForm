namespace hotel_management
{
    partial class WorkingDays
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
            this.numericUpDownAmountOfWorkdays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAmountOfWorkdays = new System.Windows.Forms.Label();
            this.checkBoxUneven = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfWorkdays)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmountOfWorkdays
            // 
            this.numericUpDownAmountOfWorkdays.Location = new System.Drawing.Point(259, 98);
            this.numericUpDownAmountOfWorkdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownAmountOfWorkdays.Name = "numericUpDownAmountOfWorkdays";
            this.numericUpDownAmountOfWorkdays.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownAmountOfWorkdays.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // labelAmountOfWorkdays
            // 
            this.labelAmountOfWorkdays.AutoSize = true;
            this.labelAmountOfWorkdays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmountOfWorkdays.Location = new System.Drawing.Point(55, 97);
            this.labelAmountOfWorkdays.Name = "labelAmountOfWorkdays";
            this.labelAmountOfWorkdays.Size = new System.Drawing.Size(198, 28);
            this.labelAmountOfWorkdays.TabIndex = 21;
            this.labelAmountOfWorkdays.Text = "Amount of workdays:";
            // 
            // checkBoxUneven
            // 
            this.checkBoxUneven.AutoSize = true;
            this.checkBoxUneven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxUneven.Location = new System.Drawing.Point(55, 43);
            this.checkBoxUneven.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxUneven.Name = "checkBoxUneven";
            this.checkBoxUneven.Size = new System.Drawing.Size(316, 32);
            this.checkBoxUneven.TabIndex = 22;
            this.checkBoxUneven.Text = "Uneven workload between staffs";
            this.checkBoxUneven.UseVisualStyleBackColor = true;
            this.checkBoxUneven.CheckedChanged += new System.EventHandler(this.checkBoxUneven_CheckedChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(109, 155);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(238, 52);
            this.buttonConfirm.TabIndex = 23;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // WorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 225);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxUneven);
            this.Controls.Add(this.labelAmountOfWorkdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAmountOfWorkdays);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkingDays";
            this.Text = "WorkingDays";
            this.Load += new System.EventHandler(this.WorkingDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfWorkdays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownAmountOfWorkdays;
        private Label label1;
        private Label labelAmountOfWorkdays;
        private CheckBox checkBoxUneven;
        private Button buttonConfirm;
    }
}