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
    public partial class WorkingDays : Form
    {
        int days;
        CreateSchedule schedule;
        public WorkingDays()
        {
            InitializeComponent();
        }

        public WorkingDays(List<STAFF> staffs, CreateSchedule cs)
        {
            InitializeComponent();
            List<RoleAmount> roles = categorizeStaffList(staffs);
            List<int> numbers = new List<int>();
            foreach (RoleAmount role in roles)
            {
                numbers.Add(role.amount);
            }
            days = LCM(numbers);
            schedule = cs;
        }

        private void WorkingDays_Load(object sender, EventArgs e)
        {
            numericUpDownAmountOfWorkdays.Value = days;
            numericUpDownAmountOfWorkdays.Increment = days;
            numericUpDownAmountOfWorkdays.Minimum = days;
        }

        private List<RoleAmount> categorizeStaffList(List<STAFF> staffs)
        {
            //create lists of staffs in roles
            List<RoleAmount> roles = new List<RoleAmount>();
            //add list of roles
            foreach(STAFF staff in staffs)
            {
                RoleAmount role = roles.FirstOrDefault(p => p.roleName == staff.staff_type);
                if (role == null)
                {
                    roles.Add(new RoleAmount { roleName = staff.staff_type, amount = 1 });
                }
                else
                {
                    role.amount++;
                }
            }
            return roles;
        }

        //finding total work days
        //function to find least common multiple
        static int LCM(List<int> numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static int lcm(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private void checkBoxUneven_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUneven.Checked)
            {
                numericUpDownAmountOfWorkdays.Value = 1;
                numericUpDownAmountOfWorkdays.Increment = 1;
                numericUpDownAmountOfWorkdays.Minimum = 1;
            }
            else
            {
                numericUpDownAmountOfWorkdays.Value = days;
                numericUpDownAmountOfWorkdays.Increment = days;
                numericUpDownAmountOfWorkdays.Minimum = days;
            }
        }

        private void numericUpDownAmountOfWorkdays_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAmountOfWorkdays.Value % days != 0)
            {
                checkBoxUneven.Checked = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            schedule.setWorkdays(Convert.ToInt16(numericUpDownAmountOfWorkdays.Value));
        }
    }
}
