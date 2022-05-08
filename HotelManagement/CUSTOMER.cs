using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string sex { get; set; }
        public string id { get; set; }
        public string DOB;
        public string RoomNumber;
        public string OrderID;
        public string checkInDate;
        public string checkOutDate;
        public string roomType;
        public bool Existed = false;

        MyDB mydb = new MyDB();


        public Customer()
        {
        }


        //check in db if customer exists
        //if exists, return true
        //else return false

        public bool CustomerExisted(string id)
        {
            var exists = mydb.existedKey("Customer", "ID", id);
            if (exists)
            {
                Existed = true;
                return true;
            }
            return false;
        }


        //insert new customer to db
        //return true if success
        //return false if fail
        public bool InsertCustomer()
        {
            var insert = mydb.insertCustomer(this);
            return true;
        }
    }
}
