using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class Staff
    {
        //lưu id cũa staff là được
        int id;
        string name;
        string address;
        string phone;
        public string type { get; set; }
        Image image;
        
    }
    internal class StaffList
    {
        public string type { get; set; }
        public List<Staff> staffs { get; set; }


    }
}
