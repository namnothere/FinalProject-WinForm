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
        List<STAFF> staffs = new List<STAFF>();
        

        public void setShiftInfo(DateTime start, DateTime end, List<STAFF> staffs)
        {
            this.start = start;
            this.end = end;
            foreach (STAFF staff in staffs)
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

        public List<STAFF> getStaffs()
        {
            return staffs;
        }
    }
}
