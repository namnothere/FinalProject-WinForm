using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class ShiftInfo
    {
        DateTime start = new DateTime();
        DateTime end = new DateTime();
        List<Staff> staffs = new List<Staff>();
    }
}
