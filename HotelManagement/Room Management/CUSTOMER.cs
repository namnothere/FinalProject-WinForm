using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DateTime DOB;
        public int RoomNumber;
        //public string OrderID;
        //public string checkInDate;
        //public string checkOutDate;
        //public string roomType;
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
        public bool insertCustomer(int id, int roomNo, string name, string address, string phone, string sex, DateTime dob)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES (@id, @roomNo, @name, @address, @phone, @sex, @dob)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.AddWithValue("@phone", SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.AddWithValue("@sex", SqlDbType.NVarChar).Value = sex;
            cmd.Parameters.AddWithValue("@dob", SqlDbType.DateTime).Value = dob;
            cmd.Parameters.AddWithValue("@roomNo", SqlDbType.Int).Value = roomNo;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool insertCustomer()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES (@id, @roomNo, @name, @address, @phone, @sex, @dob)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = this.id;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = this.name;
            cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = this.address;
            cmd.Parameters.AddWithValue("@phone", SqlDbType.NVarChar).Value = this.phone;
            cmd.Parameters.AddWithValue("@sex", SqlDbType.NVarChar).Value = this.sex;
            cmd.Parameters.AddWithValue("@dob", SqlDbType.DateTime).Value = this.DOB;
            cmd.Parameters.AddWithValue("@roomNo", SqlDbType.Int).Value = this.RoomNumber;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        
        public bool updateCustomer()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET Address = @address, Phone = @phone, Sex = @sex, DOB = @dob, roomNo = @roomNo, Name = @name WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = this.id;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = this.name;
            cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = this.address;
            cmd.Parameters.AddWithValue("@phone", SqlDbType.NVarChar).Value = this.phone;
            cmd.Parameters.AddWithValue("@sex", SqlDbType.NVarChar).Value = this.sex;
            cmd.Parameters.AddWithValue("@dob", SqlDbType.DateTime).Value = this.DOB;
            cmd.Parameters.AddWithValue("@roomNo", SqlDbType.Int).Value = this.RoomNumber;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public Customer getCustomerByID(int id)
        {
            Customer c = new Customer();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE ID = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c.id = reader["ID"].ToString();
                c.name = reader["Name"].ToString();
                c.address = reader["Address"].ToString();
                c.phone = reader["Phone"].ToString();
                c.RoomNumber = Convert.ToInt32(reader["roomNo"]);
                c.sex = reader["sex"].ToString();
                c.DOB = (DateTime)reader["DOB"];
            }

            return c;

        }        

        public DataTable getAllCustomers()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
