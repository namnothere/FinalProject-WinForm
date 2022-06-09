namespace hotel_management
{
    partial class CreateSchedule
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
            this.labelNoOfShift = new System.Windows.Forms.Label();
            this.labelStartDay = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.dateTimePickerStartDay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownJanitorAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReceptionistAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownManagerAmount = new System.Windows.Forms.NumericUpDown();
            this.panelWeekday = new System.Windows.Forms.Panel();
            this.labelWeekday = new System.Windows.Forms.Label();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.panelInterchangebleStaff = new System.Windows.Forms.Panel();
            this.numericUpDownAmountOfStaff = new System.Windows.Forms.NumericUpDown();
            this.labelAmountOfStaff = new System.Windows.Forms.Label();
            this.checkBoxIEReceptionist = new System.Windows.Forms.CheckBox();
            this.checkBoxIEManager = new System.Windows.Forms.CheckBox();
            this.labelStaffTypes = new System.Windows.Forms.Label();
            this.checkBoxIEJanitor = new System.Windows.Forms.CheckBox();
            this.checkBoxInterchangableStaff = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftJanitor = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftReceptionist = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftManager = new System.Windows.Forms.CheckBox();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTimeSpan = new System.Windows.Forms.Label();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.buttonCreateSchedule = new System.Windows.Forms.Button();
            this.labelMaxHourPerShift = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonSpecialDaysSetting = new System.Windows.Forms.RadioButton();
            this.radioButtonNormalDaysSetting = new System.Windows.Forms.RadioButton();
            this.numericUpDownShiftPerDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxHourPerShift = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJanitorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReceptionistAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManagerAmount)).BeginInit();
            this.panelWeekday.SuspendLayout();
            this.panelInterchangebleStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfStaff)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHourPerShift)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoOfShift
            // 
            this.labelNoOfShift.AutoSize = true;
            this.labelNoOfShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoOfShift.Location = new System.Drawing.Point(14, 27);
            this.labelNoOfShift.Name = "labelNoOfShift";
            this.labelNoOfShift.Size = new System.Drawing.Size(227, 28);
            this.labelNoOfShift.TabIndex = 0;
            this.labelNoOfShift.Text = "Number of Shift Per Day:";
            // 
            // labelStartDay
            // 
            this.labelStartDay.AutoSize = true;
            this.labelStartDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartDay.Location = new System.Drawing.Point(135, 72);
            this.labelStartDay.Name = "labelStartDay";
            this.labelStartDay.Size = new System.Drawing.Size(96, 28);
            this.labelStartDay.TabIndex = 2;
            this.labelStartDay.Text = "Start Day:";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShift.Location = new System.Drawing.Point(30, 27);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(52, 28);
            this.labelShift.TabIndex = 3;
            this.labelShift.Text = "Shift";
            // 
            // dateTimePickerStartDay
            // 
            this.dateTimePickerStartDay.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDay.Location = new System.Drawing.Point(247, 67);
            this.dateTimePickerStartDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStartDay.Name = "dateTimePickerStartDay";
            this.dateTimePickerStartDay.Size = new System.Drawing.Size(130, 34);
            this.dateTimePickerStartDay.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownJanitorAmount);
            this.panel2.Controls.Add(this.numericUpDownReceptionistAmount);
            this.panel2.Controls.Add(this.numericUpDownManagerAmount);
            this.panel2.Controls.Add(this.panelWeekday);
            this.panel2.Controls.Add(this.panelInterchangebleStaff);
            this.panel2.Controls.Add(this.checkBoxInterchangableStaff);
            this.panel2.Controls.Add(this.checkBoxShiftJanitor);
            this.panel2.Controls.Add(this.checkBoxShiftReceptionist);
            this.panel2.Controls.Add(this.checkBoxShiftManager);
            this.panel2.Controls.Add(this.labelStaff);
            this.panel2.Controls.Add(this.labelTo);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Controls.Add(this.labelTimeSpan);
            this.panel2.Controls.Add(this.comboBoxShift);
            this.panel2.Controls.Add(this.labelShift);
            this.panel2.Location = new System.Drawing.Point(14, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 471);
            this.panel2.TabIndex = 8;
            // 
            // numericUpDownJanitorAmount
            // 
            this.numericUpDownJanitorAmount.Enabled = false;
            this.numericUpDownJanitorAmount.Location = new System.Drawing.Point(167, 265);
            this.numericUpDownJanitorAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownJanitorAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJanitorAmount.Name = "numericUpDownJanitorAmount";
            this.numericUpDownJanitorAmount.Size = new System.Drawing.Size(83, 27);
            this.numericUpDownJanitorAmount.TabIndex = 29;
            this.numericUpDownJanitorAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJanitorAmount.ValueChanged += new System.EventHandler(this.numericUpDownJanitorAmount_ValueChanged);
            // 
            // numericUpDownReceptionistAmount
            // 
            this.numericUpDownReceptionistAmount.Enabled = false;
            this.numericUpDownReceptionistAmount.Location = new System.Drawing.Point(167, 224);
            this.numericUpDownReceptionistAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownReceptionistAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownReceptionistAmount.Name = "numericUpDownReceptionistAmount";
            this.numericUpDownReceptionistAmount.Size = new System.Drawing.Size(83, 27);
            this.numericUpDownReceptionistAmount.TabIndex = 28;
            this.numericUpDownReceptionistAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownReceptionistAmount.ValueChanged += new System.EventHandler(this.numericUpDownReceptionistAmount_ValueChanged);
            // 
            // numericUpDownManagerAmount
            // 
            this.numericUpDownManagerAmount.Enabled = false;
            this.numericUpDownManagerAmount.Location = new System.Drawing.Point(167, 183);
            this.numericUpDownManagerAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownManagerAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownManagerAmount.Name = "numericUpDownManagerAmount";
            this.numericUpDownManagerAmount.Size = new System.Drawing.Size(83, 27);
            this.numericUpDownManagerAmount.TabIndex = 25;
            this.numericUpDownManagerAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownManagerAmount.ValueChanged += new System.EventHandler(this.numericUpDownManagerAmount_ValueChanged);
            // 
            // panelWeekday
            // 
            this.panelWeekday.Controls.Add(this.labelWeekday);
            this.panelWeekday.Controls.Add(this.checkBoxSunday);
            this.panelWeekday.Controls.Add(this.checkBoxMonday);
            this.panelWeekday.Controls.Add(this.checkBoxSaturday);
            this.panelWeekday.Controls.Add(this.checkBoxTuesday);
            this.panelWeekday.Controls.Add(this.checkBoxFriday);
            this.panelWeekday.Controls.Add(this.checkBoxWednesday);
            this.panelWeekday.Controls.Add(this.checkBoxThursday);
            this.panelWeekday.Location = new System.Drawing.Point(270, 125);
            this.panelWeekday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWeekday.Name = "panelWeekday";
            this.panelWeekday.Size = new System.Drawing.Size(305, 215);
            this.panelWeekday.TabIndex = 27;
            this.panelWeekday.Visible = false;
            // 
            // labelWeekday
            // 
            this.labelWeekday.AutoSize = true;
            this.labelWeekday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWeekday.Location = new System.Drawing.Point(34, 11);
            this.labelWeekday.Name = "labelWeekday";
            this.labelWeekday.Size = new System.Drawing.Size(96, 28);
            this.labelWeekday.TabIndex = 19;
            this.labelWeekday.Text = "Weekday:";
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSunday.Location = new System.Drawing.Point(176, 140);
            this.checkBoxSunday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(99, 32);
            this.checkBoxSunday.TabIndex = 26;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMonday.Location = new System.Drawing.Point(23, 57);
            this.checkBoxMonday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(107, 32);
            this.checkBoxMonday.TabIndex = 20;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSaturday.Location = new System.Drawing.Point(176, 99);
            this.checkBoxSaturday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(112, 32);
            this.checkBoxSaturday.TabIndex = 25;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTuesday.Location = new System.Drawing.Point(23, 99);
            this.checkBoxTuesday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(105, 32);
            this.checkBoxTuesday.TabIndex = 21;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFriday.Location = new System.Drawing.Point(176, 57);
            this.checkBoxFriday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(88, 32);
            this.checkBoxFriday.TabIndex = 24;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxWednesday.Location = new System.Drawing.Point(23, 140);
            this.checkBoxWednesday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(135, 32);
            this.checkBoxWednesday.TabIndex = 22;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxThursday.Location = new System.Drawing.Point(23, 179);
            this.checkBoxThursday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(113, 32);
            this.checkBoxThursday.TabIndex = 23;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // panelInterchangebleStaff
            // 
            this.panelInterchangebleStaff.Controls.Add(this.numericUpDownAmountOfStaff);
            this.panelInterchangebleStaff.Controls.Add(this.labelAmountOfStaff);
            this.panelInterchangebleStaff.Controls.Add(this.checkBoxIEReceptionist);
            this.panelInterchangebleStaff.Controls.Add(this.checkBoxIEManager);
            this.panelInterchangebleStaff.Controls.Add(this.labelStaffTypes);
            this.panelInterchangebleStaff.Controls.Add(this.checkBoxIEJanitor);
            this.panelInterchangebleStaff.Location = new System.Drawing.Point(30, 348);
            this.panelInterchangebleStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInterchangebleStaff.Name = "panelInterchangebleStaff";
            this.panelInterchangebleStaff.Size = new System.Drawing.Size(565, 109);
            this.panelInterchangebleStaff.TabIndex = 17;
            this.panelInterchangebleStaff.Visible = false;
            // 
            // numericUpDownAmountOfStaff
            // 
            this.numericUpDownAmountOfStaff.Location = new System.Drawing.Point(199, 23);
            this.numericUpDownAmountOfStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownAmountOfStaff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountOfStaff.Name = "numericUpDownAmountOfStaff";
            this.numericUpDownAmountOfStaff.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownAmountOfStaff.TabIndex = 24;
            this.numericUpDownAmountOfStaff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountOfStaff.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfStaff_ValueChanged);
            // 
            // labelAmountOfStaff
            // 
            this.labelAmountOfStaff.AutoSize = true;
            this.labelAmountOfStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmountOfStaff.Location = new System.Drawing.Point(16, 23);
            this.labelAmountOfStaff.Name = "labelAmountOfStaff";
            this.labelAmountOfStaff.Size = new System.Drawing.Size(154, 28);
            this.labelAmountOfStaff.TabIndex = 23;
            this.labelAmountOfStaff.Text = "Amount of Staff:";
            // 
            // checkBoxIEReceptionist
            // 
            this.checkBoxIEReceptionist.AutoSize = true;
            this.checkBoxIEReceptionist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIEReceptionist.Location = new System.Drawing.Point(318, 65);
            this.checkBoxIEReceptionist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIEReceptionist.Name = "checkBoxIEReceptionist";
            this.checkBoxIEReceptionist.Size = new System.Drawing.Size(141, 32);
            this.checkBoxIEReceptionist.TabIndex = 18;
            this.checkBoxIEReceptionist.Text = "Receptionist";
            this.checkBoxIEReceptionist.UseVisualStyleBackColor = true;
            this.checkBoxIEReceptionist.CheckedChanged += new System.EventHandler(this.checkBoxIEReceptionist_CheckedChanged);
            // 
            // checkBoxIEManager
            // 
            this.checkBoxIEManager.AutoSize = true;
            this.checkBoxIEManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIEManager.Location = new System.Drawing.Point(209, 65);
            this.checkBoxIEManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIEManager.Name = "checkBoxIEManager";
            this.checkBoxIEManager.Size = new System.Drawing.Size(112, 32);
            this.checkBoxIEManager.TabIndex = 18;
            this.checkBoxIEManager.Text = "Manager";
            this.checkBoxIEManager.UseVisualStyleBackColor = true;
            this.checkBoxIEManager.CheckedChanged += new System.EventHandler(this.checkBoxIEManager_CheckedChanged);
            // 
            // labelStaffTypes
            // 
            this.labelStaffTypes.AutoSize = true;
            this.labelStaffTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStaffTypes.Location = new System.Drawing.Point(16, 65);
            this.labelStaffTypes.Name = "labelStaffTypes";
            this.labelStaffTypes.Size = new System.Drawing.Size(109, 28);
            this.labelStaffTypes.TabIndex = 19;
            this.labelStaffTypes.Text = "Staff Types:";
            // 
            // checkBoxIEJanitor
            // 
            this.checkBoxIEJanitor.AutoSize = true;
            this.checkBoxIEJanitor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIEJanitor.Location = new System.Drawing.Point(465, 64);
            this.checkBoxIEJanitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIEJanitor.Name = "checkBoxIEJanitor";
            this.checkBoxIEJanitor.Size = new System.Drawing.Size(93, 32);
            this.checkBoxIEJanitor.TabIndex = 18;
            this.checkBoxIEJanitor.Text = "Janitor";
            this.checkBoxIEJanitor.UseVisualStyleBackColor = true;
            this.checkBoxIEJanitor.CheckedChanged += new System.EventHandler(this.checkBoxIEJanitor_CheckedChanged);
            // 
            // checkBoxInterchangableStaff
            // 
            this.checkBoxInterchangableStaff.AutoSize = true;
            this.checkBoxInterchangableStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxInterchangableStaff.Location = new System.Drawing.Point(30, 307);
            this.checkBoxInterchangableStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxInterchangableStaff.Name = "checkBoxInterchangableStaff";
            this.checkBoxInterchangableStaff.Size = new System.Drawing.Size(208, 32);
            this.checkBoxInterchangableStaff.TabIndex = 16;
            this.checkBoxInterchangableStaff.Text = "Interchangable Staff";
            this.checkBoxInterchangableStaff.UseVisualStyleBackColor = true;
            this.checkBoxInterchangableStaff.CheckedChanged += new System.EventHandler(this.checkBoxInterchangableStaff_CheckedChanged);
            // 
            // checkBoxShiftJanitor
            // 
            this.checkBoxShiftJanitor.AutoSize = true;
            this.checkBoxShiftJanitor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShiftJanitor.Location = new System.Drawing.Point(30, 265);
            this.checkBoxShiftJanitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShiftJanitor.Name = "checkBoxShiftJanitor";
            this.checkBoxShiftJanitor.Size = new System.Drawing.Size(93, 32);
            this.checkBoxShiftJanitor.TabIndex = 15;
            this.checkBoxShiftJanitor.Text = "Janitor";
            this.checkBoxShiftJanitor.UseVisualStyleBackColor = true;
            this.checkBoxShiftJanitor.CheckedChanged += new System.EventHandler(this.checkBoxShiftJanitor_CheckedChanged);
            // 
            // checkBoxShiftReceptionist
            // 
            this.checkBoxShiftReceptionist.AutoSize = true;
            this.checkBoxShiftReceptionist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShiftReceptionist.Location = new System.Drawing.Point(30, 224);
            this.checkBoxShiftReceptionist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShiftReceptionist.Name = "checkBoxShiftReceptionist";
            this.checkBoxShiftReceptionist.Size = new System.Drawing.Size(141, 32);
            this.checkBoxShiftReceptionist.TabIndex = 14;
            this.checkBoxShiftReceptionist.Text = "Receptionist";
            this.checkBoxShiftReceptionist.UseVisualStyleBackColor = true;
            this.checkBoxShiftReceptionist.CheckedChanged += new System.EventHandler(this.checkBoxShiftReceptionist_CheckedChanged);
            // 
            // checkBoxShiftManager
            // 
            this.checkBoxShiftManager.AutoSize = true;
            this.checkBoxShiftManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShiftManager.Location = new System.Drawing.Point(30, 183);
            this.checkBoxShiftManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxShiftManager.Name = "checkBoxShiftManager";
            this.checkBoxShiftManager.Size = new System.Drawing.Size(112, 32);
            this.checkBoxShiftManager.TabIndex = 6;
            this.checkBoxShiftManager.Text = "Manager";
            this.checkBoxShiftManager.UseVisualStyleBackColor = true;
            this.checkBoxShiftManager.CheckedChanged += new System.EventHandler(this.checkBoxShiftManager_CheckedChanged);
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStaff.Location = new System.Drawing.Point(30, 136);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(55, 28);
            this.labelStaff.TabIndex = 13;
            this.labelStaff.Text = "Staff:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(270, 84);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(31, 28);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "to";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTo.CustomFormat = "HH:mm";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(307, 79);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerTo.MaxDate = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.dateTimePickerTo.MinDate = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(127, 34);
            this.dateTimePickerTo.TabIndex = 11;
            this.dateTimePickerTo.Value = new System.DateTime(2022, 6, 9, 1, 0, 0, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFrom.CustomFormat = "HH:mm";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(137, 79);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(127, 34);
            this.dateTimePickerFrom.TabIndex = 9;
            this.dateTimePickerFrom.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labelTimeSpan
            // 
            this.labelTimeSpan.AutoSize = true;
            this.labelTimeSpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan.Location = new System.Drawing.Point(30, 84);
            this.labelTimeSpan.Name = "labelTimeSpan";
            this.labelTimeSpan.Size = new System.Drawing.Size(107, 28);
            this.labelTimeSpan.TabIndex = 10;
            this.labelTimeSpan.Text = "Time Span:";
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Location = new System.Drawing.Point(80, 23);
            this.comboBoxShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(53, 36);
            this.comboBoxShift.TabIndex = 9;
            this.comboBoxShift.SelectedIndexChanged += new System.EventHandler(this.comboBoxShift_SelectedIndexChanged);
            // 
            // buttonCreateSchedule
            // 
            this.buttonCreateSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateSchedule.Location = new System.Drawing.Point(210, 696);
            this.buttonCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateSchedule.Name = "buttonCreateSchedule";
            this.buttonCreateSchedule.Size = new System.Drawing.Size(238, 52);
            this.buttonCreateSchedule.TabIndex = 19;
            this.buttonCreateSchedule.Text = "Create Schedule";
            this.buttonCreateSchedule.UseVisualStyleBackColor = true;
            this.buttonCreateSchedule.Click += new System.EventHandler(this.buttonCreateSchedule_Click);
            // 
            // labelMaxHourPerShift
            // 
            this.labelMaxHourPerShift.AutoSize = true;
            this.labelMaxHourPerShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxHourPerShift.Location = new System.Drawing.Point(60, 115);
            this.labelMaxHourPerShift.Name = "labelMaxHourPerShift";
            this.labelMaxHourPerShift.Size = new System.Drawing.Size(181, 28);
            this.labelMaxHourPerShift.TabIndex = 20;
            this.labelMaxHourPerShift.Text = "Max Hour per Shift:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonSpecialDaysSetting);
            this.panel4.Controls.Add(this.radioButtonNormalDaysSetting);
            this.panel4.Location = new System.Drawing.Point(16, 163);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 47);
            this.panel4.TabIndex = 22;
            // 
            // radioButtonSpecialDaysSetting
            // 
            this.radioButtonSpecialDaysSetting.AutoSize = true;
            this.radioButtonSpecialDaysSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSpecialDaysSetting.Location = new System.Drawing.Point(322, 9);
            this.radioButtonSpecialDaysSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSpecialDaysSetting.Name = "radioButtonSpecialDaysSetting";
            this.radioButtonSpecialDaysSetting.Size = new System.Drawing.Size(222, 32);
            this.radioButtonSpecialDaysSetting.TabIndex = 1;
            this.radioButtonSpecialDaysSetting.TabStop = true;
            this.radioButtonSpecialDaysSetting.Text = "Special Day(s) Setting";
            this.radioButtonSpecialDaysSetting.UseVisualStyleBackColor = true;
            this.radioButtonSpecialDaysSetting.CheckedChanged += new System.EventHandler(this.radioButtonSpecialDaysSetting_CheckedChanged);
            // 
            // radioButtonNormalDaysSetting
            // 
            this.radioButtonNormalDaysSetting.AutoSize = true;
            this.radioButtonNormalDaysSetting.Checked = true;
            this.radioButtonNormalDaysSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNormalDaysSetting.Location = new System.Drawing.Point(3, 9);
            this.radioButtonNormalDaysSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNormalDaysSetting.Name = "radioButtonNormalDaysSetting";
            this.radioButtonNormalDaysSetting.Size = new System.Drawing.Size(226, 32);
            this.radioButtonNormalDaysSetting.TabIndex = 0;
            this.radioButtonNormalDaysSetting.TabStop = true;
            this.radioButtonNormalDaysSetting.Text = "Normal Day(s) Setting";
            this.radioButtonNormalDaysSetting.UseVisualStyleBackColor = true;
            // 
            // numericUpDownShiftPerDay
            // 
            this.numericUpDownShiftPerDay.Location = new System.Drawing.Point(247, 28);
            this.numericUpDownShiftPerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownShiftPerDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShiftPerDay.Name = "numericUpDownShiftPerDay";
            this.numericUpDownShiftPerDay.Size = new System.Drawing.Size(130, 27);
            this.numericUpDownShiftPerDay.TabIndex = 23;
            this.numericUpDownShiftPerDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShiftPerDay.ValueChanged += new System.EventHandler(this.numericUpDownShiftPerDay_ValueChanged);
            // 
            // numericUpDownMaxHourPerShift
            // 
            this.numericUpDownMaxHourPerShift.Location = new System.Drawing.Point(250, 116);
            this.numericUpDownMaxHourPerShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownMaxHourPerShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxHourPerShift.Name = "numericUpDownMaxHourPerShift";
            this.numericUpDownMaxHourPerShift.Size = new System.Drawing.Size(130, 27);
            this.numericUpDownMaxHourPerShift.TabIndex = 24;
            this.numericUpDownMaxHourPerShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxHourPerShift.ValueChanged += new System.EventHandler(this.numericUpDownMaxHourPerShift_ValueChanged);
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(636, 777);
            this.Controls.Add(this.numericUpDownMaxHourPerShift);
            this.Controls.Add(this.numericUpDownShiftPerDay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonCreateSchedule);
            this.Controls.Add(this.labelMaxHourPerShift);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePickerStartDay);
            this.Controls.Add(this.labelNoOfShift);
            this.Controls.Add(this.labelStartDay);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateSchedule";
            this.Text = "CreateSchedule";
            this.Load += new System.EventHandler(this.CreateSchedule_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJanitorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReceptionistAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownManagerAmount)).EndInit();
            this.panelWeekday.ResumeLayout(false);
            this.panelWeekday.PerformLayout();
            this.panelInterchangebleStaff.ResumeLayout(false);
            this.panelInterchangebleStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfStaff)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHourPerShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNoOfShift;
        private Label labelStartDay;
        private Label labelShift;
        private DateTimePicker dateTimePickerStartDay;
        private Panel panel2;
        private CheckBox checkBoxShiftJanitor;
        private CheckBox checkBoxShiftReceptionist;
        private CheckBox checkBoxShiftManager;
        private Label labelStaff;
        private Label labelTo;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Label labelTimeSpan;
        private ComboBox comboBoxShift;
        private Panel panelInterchangebleStaff;
        private CheckBox checkBoxIEReceptionist;
        private CheckBox checkBoxIEManager;
        private Label labelStaffTypes;
        private CheckBox checkBoxIEJanitor;
        private CheckBox checkBoxInterchangableStaff;
        private Label labelAmountOfStaff;
        private Button buttonCreateSchedule;
        private Label labelMaxHourPerShift;
        private Panel panel4;
        private RadioButton radioButtonSpecialDaysSetting;
        private RadioButton radioButtonNormalDaysSetting;
        private Label labelWeekday;
        private Panel panelWeekday;
        private CheckBox checkBoxSunday;
        private CheckBox checkBoxMonday;
        private CheckBox checkBoxSaturday;
        private CheckBox checkBoxTuesday;
        private CheckBox checkBoxFriday;
        private CheckBox checkBoxWednesday;
        private CheckBox checkBoxThursday;
        private NumericUpDown numericUpDownShiftPerDay;
        private NumericUpDown numericUpDownMaxHourPerShift;
        private NumericUpDown numericUpDownAmountOfStaff;
        private NumericUpDown numericUpDownJanitorAmount;
        private NumericUpDown numericUpDownReceptionistAmount;
        private NumericUpDown numericUpDownManagerAmount;
    }
}