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
        Staff staff = new Staff();
        int selectedShift;
        List<ShiftState> shifts = new List<ShiftState>();


        internal class ShiftState
        {
            public int shiftNum;
            public TimeOnly from;
            public TimeOnly to;

            public bool manager;
            public int managerAmount;
            public bool receptionist;
            public int receptionistAmount;
            public bool janitor;
            public int janitorAmount;

            public bool specialDay;
            public bool monday;
            public bool tuesday;
            public bool wednesday;
            public bool thursday;
            public bool friday;
            public bool saturday;
            public bool sunday;

            public bool interchangebleStaff;
            public int amountOfStaff;
            public bool IEmanager;
            public bool IEreceptionist;
            public bool IEjanitor;
        }

        private void saveState()
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

            shift.specialDay = radioButtonNormalDaysSetting.Checked;
            if (shift.specialDay)
            {
                shift.monday = checkBoxMonday.Checked;
                shift.tuesday = checkBoxTuesday.Checked;
                shift.wednesday = checkBoxWednesday.Checked;
                shift.thursday = checkBoxThursday.Checked;
                shift.friday = checkBoxFriday.Checked;
                shift.saturday = checkBoxSaturday.Checked;
                shift.sunday = checkBoxSunday.Checked;
            }

            shift.interchangebleStaff = checkBoxInterchangableStaff.Checked;
            if (shift.interchangebleStaff)
            {
                shift.amountOfStaff = Convert.ToInt16(numericUpDownAmountOfStaff.Value);
                shift.IEmanager = checkBoxIEManager.Checked;
                shift.IEreceptionist = checkBoxIEReceptionist.Checked;
                shift.IEjanitor = checkBoxIEJanitor.Checked;
            }

            shifts.Add(shift);
        }

        private void loadState(int shiftNum, bool spec)
        {
            var match = shifts.Where(p => p.shiftNum == shiftNum && p.specialDay == spec);
            if (match.Count() > 0)
            {
                foreach (ShiftState shift in match)
                {
                    dateTimePickerFrom.Value = DateOnly.FromDateTime(DateTime.Today).ToDateTime(shift.from);
                    dateTimePickerTo.Value = DateOnly.FromDateTime(DateTime.Today).ToDateTime(shift.to);
                    checkBoxShiftManager.Checked = shift.manager;
                    checkBoxShiftReceptionist.Checked = shift.receptionist;
                    checkBoxShiftJanitor.Checked = shift.janitor;

                    if (spec)
                    {
                        checkBoxMonday.Checked = shift.monday;
                        checkBoxTuesday.Checked = shift.tuesday;
                        checkBoxWednesday.Checked = shift.wednesday;
                        checkBoxThursday.Checked = shift.thursday;
                        checkBoxFriday.Checked = shift.friday;
                        checkBoxSaturday.Checked = shift.saturday;
                        checkBoxSunday.Checked = shift.sunday;
                    }

                    checkBoxInterchangableStaff.Checked = shift.interchangebleStaff;
                    if (shift.interchangebleStaff)
                    {
                        numericUpDownAmountOfStaff.Value = shift.amountOfStaff;
                        checkBoxIEManager.Checked = shift.IEmanager;
                        checkBoxIEReceptionist.Checked = shift.IEreceptionist;
                        checkBoxIEJanitor.Checked = shift.IEjanitor;
                    }
                }
            }
            else
            {
                dateTimePickerFrom.Value = DateTime.Today;
                dateTimePickerTo.Value = DateTime.Today;
                checkBoxShiftManager.Checked = false;
                checkBoxShiftReceptionist.Checked = false;
                checkBoxShiftJanitor.Checked = false;
                if (spec)
                {
                    checkBoxMonday.Checked = false;
                    checkBoxTuesday.Checked = false;
                    checkBoxWednesday.Checked = false;
                    checkBoxThursday.Checked = false;
                    checkBoxFriday.Checked = false;
                    checkBoxSaturday.Checked = false;
                    checkBoxSunday.Checked = false;
                }
                checkBoxInterchangableStaff.Checked = false;

            }
        }

        //sort shifts according to time span
        //only input shifts from 1 type of day
        private void shiftSort(List<ShiftState> shifts)
        {
            //insertion sort
            for (int i = 1; i < shifts.Count(); ++i)
            {
                TimeOnly key = shifts.FirstOrDefault(p => p.shiftNum == i).from;
                int j = i - 1;

                while (j >= 0 && shifts.FirstOrDefault(p => p.shiftNum == j).from > key)
                {
                    shifts.FirstOrDefault(p => p.shiftNum == j + 1).shiftNum = shifts.FirstOrDefault(p => p.shiftNum == j).shiftNum;
                    j = j - 1;
                }
                shifts.FirstOrDefault(p => p.shiftNum == j + 1).from = key;
            }
        }

        private bool checkState(List<ShiftState> shifts, bool spec)
        {
            //check exception
            //if time between shifts are overlapped
            string type = "Special Days";
            if (spec)
            {
                type = "Special Days";
            }
            else
            {
                type = "Normal Days";
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
                            if (!(match1.from < match2.to && match1.to > match2.from))
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

        //finding total work days

        //function to find least common multiple
        static long LCM(List<long> numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static long lcm(long a, long b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }


        public CreateSchedule()
        {
            InitializeComponent();
        }

        private void CreateSchedule_Load(object sender, EventArgs e)
        {
            comboBoxShift.DataSource = 1;
            List<int> index = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                index.Add(i);
            }
            selectedShift = 1;
        }

        private void radioButtonSpecialDaysSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSpecialDaysSetting.Checked)
                panelWeekday.Visible = true;
            else 
                panelWeekday.Visible = false;
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
            saveState();
            loadState(comboBoxShift.SelectedIndex, radioButtonSpecialDaysSetting.Checked);
            selectedShift = comboBoxShift.SelectedIndex;
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
                DateTime tempfrom = dateTimePickerTo.Value;
                tempfrom.AddMinutes(-1);
                dateTimePickerFrom.Value = tempfrom;
            }
        }
        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerTo.Value <= dateTimePickerFrom.Value)
            {
                MessageBox.Show("To field must be greater than From field", "Create Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DateTime tempto = dateTimePickerFrom.Value;
                tempto.AddMinutes(1);
                dateTimePickerFrom.Value = tempto;
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
                numericUpDownManagerAmount.Enabled = false;
            }
            else
            {
                checkBoxShiftManager.Enabled = true;
                numericUpDownManagerAmount.Enabled = true;
            }
        }
        private void checkBoxIEReceptionist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIEReceptionist.Checked == true)
            {
                checkBoxShiftReceptionist.Checked = false;
                checkBoxShiftReceptionist.Enabled = false;
                numericUpDownReceptionistAmount.Enabled = false;
            }
            else
            {
                checkBoxShiftReceptionist.Enabled = true;
                numericUpDownReceptionistAmount.Enabled = true;
            }
        }
        private void checkBoxIEJanitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIEJanitor.Checked == true)
            {
                checkBoxShiftJanitor.Checked = false;
                checkBoxShiftJanitor.Enabled = false;
                numericUpDownJanitorAmount.Enabled = false;
            }
            else
            {
                checkBoxShiftJanitor.Enabled = true;
                numericUpDownJanitorAmount.Enabled = true;
            }
        }
        private void buttonSaveScheduleInfo_Click(object sender, EventArgs e)
        {
            saveState();
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
            }
        }

        private List<Requirement> convertStateToReqList (List<ShiftState> shifts)
        {
            List<Requirement> req = new List<Requirement>();
            for (int i = 1; i <= shifts.Count(); i++)
            {
                Requirement reqSingle = new Requirement();
                
                ShiftState shift = shifts.FirstOrDefault(p => p.shiftNum == i);
                reqSingle.start = shift.from;
                reqSingle.end = shift.to;

                List<RoleAmount> roles = new List<RoleAmount>();
                RoleAmount role = new RoleAmount();
                if (shift.manager)
                {
                    role.roleName = "Manager";
                    role.amount = shift.managerAmount;
                    roles.Add(role);
                }
                if (shift.receptionist)
                {
                    role.roleName = "Receptionist";
                    role.amount = shift.receptionistAmount;
                    roles.Add(role);
                }
                if (shift.janitor)
                {
                    role.roleName = "Janitor";
                    role.amount = shift.janitorAmount;
                    roles.Add(role);
                }
                if (shift.interchangebleStaff)
                {
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
    }
}
