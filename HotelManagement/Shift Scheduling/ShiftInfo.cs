using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    class ShiftInfo
    {
        DateTime start = new DateTime();
        DateTime end = new DateTime();
        List<Staff> staffs = new List<Staff>();
        

        public void setShiftInfo(DateTime start, DateTime end, List<Staff> staffs)
        {
            this.start = start;
            this.end = end;
            foreach (Staff staff in staffs)
            {
                this.staffs.Add(staff);
            }
        }

        public DateTime getStart()
        {
            return start;
        }

        public DateTime getEnd()
        {
            return end;
        }

        public List<Staff> getStaffs()
        {
            return staffs;
        }
    }
}
