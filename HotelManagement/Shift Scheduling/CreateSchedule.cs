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
    public partial class CreateSchedule : Form
    {
        Schedule schedule = new Schedule();

        STAFF staff = new STAFF();
        List<STAFF> staffList = new List<STAFF>();

        int workdays;

        private void fillStaffList()
        {
            foreach (DataRow dr in staff.getAllEmployees().Rows)
            {
                staff = new STAFF();
                staff.convertStaff(dr);
                staffList.Add(staff);
            }
        }

        int selectedShift = 1;
        List<ShiftState> shifts = new List<ShiftState>();


        internal class ShiftState
        {
            public int shiftNum;
            public TimeOnly from;
            public TimeOnly to;

            public bool manager = false;
            public int managerAmount = 0;
            public bool receptionist = false;
            public int receptionistAmount = 0;
            public bool janitor = false;
            public int janitorAmount = 0;

            public bool specialDay = false;

            public bool interchangebleStaff = false;
            public int amountOfStaff = 0;
            public bool IEmanager = false;
            public bool IEreceptionist = false;
            public bool IEjanitor = false;
        }

        private void saveState(bool spec)
        {
            ShiftState shift = new ShiftState();
            shift.shiftNum = selectedShift;
            shift.from = TimeOnly.FromDateTime(dateTimePickerFrom.Value);
            shift.to = TimeOnly.FromDateTime(dateTimePickerTo.Value);
            shift.manager = checkBoxShiftManager.Checked;
            shift.managerAmount = Convert.ToInt16(numericUpDownManagerAmount.Value);
            shift.receptionist = checkBoxShiftReceptionist.Checked;
            shift.receptionistAmount = Convert.ToInt16(numericUpDownReceptionistAmount.Value);
            shift.janitor = checkBoxShiftJanitor.Checked;
            shift.janitorAmount = Convert.ToInt16(numericUpDownJanitorAmount.Value);

            shift.specialDay = spec;

            shift.interchangebleStaff = checkBoxInterchangableStaff.Checked;
            if (shift.interchangebleStaff)
            {
                shift.amountOfStaff = Convert.ToInt16(numericUpDownAmountOfStaff.Value);
                shift.IEmanager = checkBoxIEManager.Checked;
                shift.IEreceptionist = checkBoxIEReceptionist.Checked;
                shift.IEjanitor = checkBoxIEJanitor.Checked;
            }

            var checkExist = shifts.Where(p => p.shiftNum == shift.shiftNum);
            if (checkExist.Count() == 0)
            {
                shifts.Add(shift);
                {
                    shift = new ShiftState();
                    shift.shiftNum = selectedShift;
                    shift.from = TimeOnly.FromDateTime(dateTimePickerFrom.Value);
                    shift.to = TimeOnly.FromDateTime(dateTimePickerTo.Value);
                    shift.manager = checkBoxShiftManager.Checked;
                    shift.managerAmount = Convert.ToInt16(numericUpDownManagerAmount.Value);
                    shift.receptionist = checkBoxShiftReceptionist.Checked;
                    shift.receptionistAmount = Convert.ToInt16(numericUpDownReceptionistAmount.Value);
                    shift.janitor = checkBoxShiftJanitor.Checked;
                    shift.janitorAmount = Convert.ToInt16(numericUpDownJanitorAmount.Value);

                    shift.specialDay = !spec;

                    shift.interchangebleStaff = checkBoxInterchangableStaff.Checked;
                    if (shift.interchangebleStaff)
                    {
                        shift.amountOfStaff = Convert.ToInt16(numericUpDownAmountOfStaff.Value);
                        shift.IEmanager = checkBoxIEManager.Checked;
                        shift.IEreceptionist = checkBoxIEReceptionist.Checked;
                        shift.IEjanitor = checkBoxIEJanitor.Checked;
                    }
                }
                shifts.Add(shift);
            }
            else
            {
                foreach (ShiftState state in checkExist)
                {
                    if (state.specialDay == shift.specialDay)
                    {
                        state.from = shift.from;
                        state.to = shift.to;
                        state.manager = shift.manager;
                        state.managerAmount = shift.managerAmount;
                        state.receptionist = shift.receptionist;
                        state.receptionistAmount = shift.receptionistAmount;
                        state.janitor = shift.janitor;
                        state.janitorAmount = shift.janitorAmount;
                        state.interchangebleStaff = shift.interchangebleStaff;
                        if (state.interchangebleStaff)
                        {
                            state.amountOfStaff = shift.amountOfStaff;
                            state.IEmanager = shift.IEmanager;
                            state.IEreceptionist = shift.IEreceptionist;
                            state.IEjanitor = shift.IEjanitor;
                        }
                        
                        //MessageBox.Show("All", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        state.from = shift.from;
                        state.to = shift.to;
                        //MessageBox.Show("Only ft", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

        }

        private void loadState(int shiftNum, bool spec)
        {
            dateTimePickerFrom.Value = DateTime.Parse("09/06/2022 00:00:00");
            dateTimePickerTo.Value = DateTime.Parse("09/06/2022 00:00:00").AddMinutes(1);
            checkBoxShiftManager.Checked = false;
            numericUpDownManagerAmount.Value = 1;
            numericUpDownManagerAmount.Enabled = false;
            checkBoxShiftReceptionist.Checked = false;
            numericUpDownReceptionistAmount.Value = 1;
            numericUpDownReceptionistAmount.Enabled = false;
            checkBoxShiftJanitor.Checked = false;
            numericUpDownJanitorAmount.Value = 1;
            numericUpDownJanitorAmount.Enabled = false;
            checkBoxInterchangableStaff.Checked = false;

            numericUpDownAmountOfStaff.Value = 1;
            checkBoxIEManager.Checked = false;
            checkBoxIEReceptionist.Checked = false;
            checkBoxIEJanitor.Checked = false;

            ShiftState shift = new ShiftState();
            shift = shifts.FirstOrDefault(p => p.shiftNum == shiftNum && p.specialDay == spec);
            
            if (shift != null)
            {
                dateTimePickerTo.Value = dateTimePickerTo.MaxDate;
                dateTimePickerFrom.Value = DateOnly.FromDateTime(DateTime.Parse("09/06/2022 00:00:00")).ToDateTime(shift.from);
                dateTimePickerTo.Value = DateOnly.FromDateTime(DateTime.Parse("09/06/2022 00:00:00")).ToDateTime(shift.to);
                checkBoxShiftManager.Checked = shift.manager;
                numericUpDownManagerAmount.Value = shift.managerAmount;
                checkBoxShiftReceptionist.Checked = shift.receptionist;
                numericUpDownReceptionistAmount.Value = shift.receptionistAmount;
                checkBoxShiftJanitor.Checked = shift.janitor;
                numericUpDownJanitorAmount.Value = shift.janitorAmount;

                checkBoxInterchangableStaff.Checked = shift.interchangebleStaff;
                if (shift.interchangebleStaff)
                {
                    numericUpDownAmountOfStaff.Value = shift.amountOfStaff;
                    checkBoxIEManager.Checked = shift.IEmanager;
                    checkBoxIEReceptionist.Checked = shift.IEreceptionist;
                    checkBoxIEJanitor.Checked = shift.IEjanitor;
                }
                else
                {
                    numericUpDownAmountOfStaff.Value = 1;
                    checkBoxIEManager.Checked = false;
                    checkBoxIEReceptionist.Checked = false;
                    checkBoxIEJanitor.Checked = false;
                }
            }
        }

        //sort shifts according to time span
        //only input shifts from 1 type of day
        private void shiftSort(List<ShiftState> shifts)
        {
            //insertion sort
            for (int i = 2; i <= shifts.Count(); ++i)
            {
                TimeOnly key = shifts.FirstOrDefault(p => p.shiftNum == i).from;
                int keyNum = shifts.FirstOrDefault(p => p.shiftNum == i).shiftNum;
                int j = i - 1;

                while (j >= 0 && shifts.FirstOrDefault(p => p.shiftNum == j).from > key)
                {
                    shifts.FirstOrDefault(p => p.shiftNum == j + 1).shiftNum = shifts.FirstOrDefault(p => p.shiftNum == j).shiftNum;
                    j = j - 1;
                }
                shifts.FirstOrDefault(p => p.shiftNum == j + 1).shiftNum = keyNum;
            }
        }

        private bool checkState(List<ShiftState> shifts, bool spec)
        {
            //check exception
            //if time between shifts are overlapped
            string type = "Special Days";
            if (spec)
            {
                type = "Special Days ";
            }
            else
            {
                type = "Normal Days ";
            }
            for (int i = 1; i <= Convert.ToInt16(numericUpDownShiftPerDay.Value) - 1; i++)
            {
                ShiftState match1 = shifts.FirstOrDefault(p => p.shiftNum == i);
                if (match1 != null)
                {
                    for (int j = i + 1; j <= Convert.ToInt16(numericUpDownShiftPerDay.Value); j++)
                    {
                        ShiftState match2 = shifts.FirstOrDefault(p => p.shiftNum == j);
                        if (match2 != null)
                        {
                            if (match1.from < match2.to && match1.to > match2.from)
                            {
                                MessageBox.Show("Shift " + i + " of " + type + "time range is overlapping with shift " + j + " time range", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Shift " + j + " of " + type + " has not been set", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Shift " + i + " of " + type + " has not been set", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;

            //check if any box of interchangable staffs are checked, if none are checked when interchangable staffs is checked, return false
            for (int i = 1; i <= Convert.ToInt16(numericUpDownShiftPerDay.Value); i++)
            {
                ShiftState match = shifts.FirstOrDefault(p => p.shiftNum == i);
                if (match.interchangebleStaff)
                {
                    if (!(match.IEmanager || match.IEreceptionist || match.IEjanitor))
                    {
                        MessageBox.Show("Shift " + i + ": If Interchangable Staff is checked, at least one of the Staff Types checkboxes must be checked. If Interchangable Staff was not meant to be checked, go back and uncheck it.", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public CreateSchedule()
        {
            InitializeComponent();
        }

        private void CreateSchedule_Load(object sender, EventArgs e)
        {
            radioButtonSpecialDaysSetting.Checked = false;
            List<int> index = new List<int>();
            index.Add(1);
            comboBoxShift.DataSource = index;
            comboBoxShift.DataSource = index;
            selectedShift = 1;
        }

        private void radioButtonSpecialDaysSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSpecialDaysSetting.Checked)
                panelWeekday.Visible = true;
            else
                panelWeekday.Visible = false;
            saveState(!radioButtonSpecialDaysSetting.Checked);
            loadState(Convert.ToInt16(comboBoxShift.SelectedValue), radioButtonSpecialDaysSetting.Checked);
        }
        private void checkBoxInterchangableStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterchangableStaff.Checked)
            {
                panelInterchangebleStaff.Visible = true;
            }
            else
            {
                panelInterchangebleStaff.Visible = false;
            }
        }
        private void comboBoxShift_SelectedIndexChanged(object sender, EventArgs e)
        {

            saveState(radioButtonSpecialDaysSetting.Checked);
            loadState(Convert.ToInt16(comboBoxShift.SelectedValue), radioButtonSpecialDaysSetting.Checked);
            selectedShift = Convert.ToInt16(comboBoxShift.SelectedValue);
        }
        private void numericUpDownShiftPerDay_ValueChanged(object sender, EventArgs e)
        {
            List<int> index = new List<int>();

            int value;
            int.TryParse(numericUpDownShiftPerDay.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Shift per Day must not be less than 1 or empty");
                numericUpDownShiftPerDay.Value = 1;
            }
            else
            {
                for (int i = 1; i <= value; i++)
                {
                    index.Add(i);
                }
                comboBoxShift.DataSource = index;
            }
        }
        private void numericUpDownMaxHourPerShift_ValueChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(numericUpDownMaxHourPerShift.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Max Hour per Shift must not be less than 1 or empty");
                numericUpDownShiftPerDay.Value = 1;
            }
        }
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value >= dateTimePickerTo.Value)
            {
                MessageBox.Show("From field must be less than To field", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePickerFrom.Value = dateTimePickerTo.Value.AddMinutes(-1);
            }
        }
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerTo.Value <= dateTimePickerFrom.Value)
            {
                MessageBox.Show("To field must be greater than From field", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePickerTo.Value = dateTimePickerFrom.Value.AddMinutes(1);
            }
        }
        private void numericUpDownManagerAmount_ValueChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(numericUpDownManagerAmount.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Manager Amount must not be less than 1 or empty");
                numericUpDownManagerAmount.Value = 1;
            }
        }
        private void numericUpDownReceptionistAmount_ValueChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(numericUpDownReceptionistAmount.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Receptionist Amount must not be less than 1 or empty");
                numericUpDownReceptionistAmount.Value = 1;
            }
        }
        private void numericUpDownJanitorAmount_ValueChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(numericUpDownJanitorAmount.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Janitor Amount must not be less than 1 or empty");
                numericUpDownJanitorAmount.Value = 1;
            }
        }
        private void numericUpDownAmountOfStaff_ValueChanged(object sender, EventArgs e)
        {
            int value;
            int.TryParse(numericUpDownAmountOfStaff.Value.ToString(), out value);
            if (value < 1)
            {
                MessageBox.Show("Shift per Day must not be less than 1 or empty");
                numericUpDownShiftPerDay.Value = 1;
            }
        }
        private void checkBoxIEManager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIEManager.Checked == true)
            {
                checkBoxShiftManager.Checked = false;
                checkBoxShiftManager.Enabled = false;
            }
            else
            {
                checkBoxShiftManager.Enabled = true;
            }
        }
        private void checkBoxIEReceptionist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIEReceptionist.Checked == true)
            {
                checkBoxShiftReceptionist.Checked = false;
                checkBoxShiftReceptionist.Enabled = false;
            }
            else
            {
                checkBoxShiftReceptionist.Enabled = true;
            }
        }
        private void checkBoxIEJanitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIEJanitor.Checked == true)
            {
                checkBoxShiftJanitor.Checked = false;
                checkBoxShiftJanitor.Enabled = false;
            }
            else
            {
                checkBoxShiftJanitor.Enabled = true;
            }
        }
        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            saveState(radioButtonSpecialDaysSetting.Checked);
            bool flag = true;
            List<ShiftState> normShifts = shifts.Where(p => !p.specialDay).ToList();
            List<ShiftState> specShifts = shifts.Where(p => p.specialDay).ToList();
            flag = checkState(normShifts, false);
            flag = checkState(specShifts, true);
            if (flag)
            {
                DateOnly start = DateOnly.FromDateTime(dateTimePickerStartDay.Value);
                int maxHours = Convert.ToInt16(numericUpDownMaxHourPerShift.Value);
                shiftSort(normShifts);
                shiftSort(specShifts);

                List<Requirement> reqNorm = convertStateToReqList(normShifts);
                List<Requirement> reqSpec = convertStateToReqList(specShifts);
           

                List<string> specDays = returnSpecialDays();
                fillStaffList();
                WorkingDays days = new WorkingDays(staffList, this);
                days.ShowDialog();
                schedule.createSchedule(start, maxHours, reqNorm, reqSpec, specDays, staffList, workdays);
                if (schedule.insertDatabase())
                {
                    MessageBox.Show("Schedule created", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Schedule not created", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private List<Requirement> convertStateToReqList(List<ShiftState> shifts)
        {
            List<Requirement> req = new List<Requirement>();
            for (int i = 1; i <= shifts.Count(); i++)
            {
                Requirement reqSingle = new Requirement();

                ShiftState shift = shifts.FirstOrDefault(p => p.shiftNum == i);
                reqSingle.start = shift.from;
                reqSingle.end = shift.to;

                List<RoleAmount> roles = new List<RoleAmount>();
                if (shift.manager)
                {
                    RoleAmount role = new RoleAmount();
                    role.roleName = "Manager";
                    role.amount = shift.managerAmount;
                    roles.Add(role);
                }
                if (shift.receptionist)
                {
                    RoleAmount role = new RoleAmount();
                    role.roleName = "Receptionist";
                    role.amount = shift.receptionistAmount;
                    roles.Add(role);
                }
                if (shift.janitor)
                {
                    RoleAmount role = new RoleAmount();
                    role.roleName = "Janitor";
                    role.amount = shift.janitorAmount;
                    roles.Add(role);
                }
                if (shift.interchangebleStaff)
                {
                    RoleAmount role = new RoleAmount();
                    role.roleName = "";
                    if (shift.IEmanager)
                    {
                        role.roleName += "Manager ";
                    }
                    if (!shift.IEreceptionist)
                    {
                        role.roleName += "Receptionist ";
                    }
                    if (shift.IEjanitor)
                    {
                        role.roleName += "Janitor ";
                    }
                    role.amount = shift.amountOfStaff;
                    roles.Add(role);
                }
                reqSingle.role = roles;
                req.Add(reqSingle);
            }
            return req;
        }

        private List<string> returnSpecialDays()
        {
            List<string> days = new List<string>();

            if (checkBoxMonday.Checked)
            {
                days.Add(checkBoxMonday.Text);
            }
            if (checkBoxTuesday.Checked)
            {
                days.Add(checkBoxTuesday.Text);
            }
            if (checkBoxWednesday.Checked)
            {
                days.Add(checkBoxWednesday.Text);
            }
            if (checkBoxThursday.Checked)
            {
                days.Add(checkBoxThursday.Text);
            }
            if (checkBoxFriday.Checked)
            {
                days.Add(checkBoxFriday.Text);
            }
            if (checkBoxSaturday.Checked)
            {
                days.Add(checkBoxSaturday.Text);
            }
            if (checkBoxSunday.Checked)
            {
                days.Add(checkBoxSunday.Text);
            }
            return days;
        }

        public void setWorkdays(int days)
        {
            workdays = days;
        }

        private void checkBoxShiftManager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftManager.Checked)
            {
                numericUpDownManagerAmount.Enabled = true;
            }
            else
            {
                numericUpDownManagerAmount.Enabled = false;
            }
        }

        private void checkBoxShiftReceptionist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftReceptionist.Checked)
            {
                numericUpDownReceptionistAmount.Enabled = true;
            }
            else
            {
                numericUpDownReceptionistAmount.Enabled = false;
            }
        }

        private void checkBoxShiftJanitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftJanitor.Checked)
            {
                numericUpDownJanitorAmount.Enabled = true;
            }
            else
            {
                numericUpDownJanitorAmount.Enabled = false;
            }
        }
    }       
}
