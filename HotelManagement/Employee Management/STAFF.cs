using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class STAFF
    {
        private string staff_id;
        private string staff_name;
        private string staff_address;
        private string staff_phone;
        private string staff_type;
        private string staff_img;

        MyDB mydb = new MyDB();

        public bool existed(string id)
        {
            //return true if the staff id is already existed
            SqlCommand cmd = new SqlCommand("SELECT * FROM staffs WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool insertEmployee(string staff_id, string staff_name, DateTime DOB, string staff_address, string staff_phone, string sex, string staff_type, string username, MemoryStream staff_img)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO staffs VALUES(@Id, @name, @DOB, @address, @phone, @sex, @type, @username, @img)", mydb.getConnection);

            cmd.Parameters.AddWithValue("@Id", staff_id);
            cmd.Parameters.AddWithValue("@name", staff_name);
            cmd.Parameters.AddWithValue("@address", staff_address);
            cmd.Parameters.AddWithValue("@phone", staff_phone);
            cmd.Parameters.AddWithValue("@type", staff_type);
            cmd.Parameters.AddWithValue("@img", staff_img.ToArray());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@sex", sex);
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

        public bool setUsernameID(string username)
        {
            ACCOUNT acc = new ACCOUNT();
            int id = acc.getID(username);
            SqlCommand cmd = new SqlCommand("UPDATE staffs SET usernameID = @id WHERE username = @username", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@username", username);
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

        public bool updateEmployee(string staff_id, string staff_name, DateTime DOB, string staff_address, string staff_phone, string sex, string staff_type, string username, MemoryStream staff_img)
        {
            SqlCommand cmd = new SqlCommand("UPDATE staffs SET name = @name, address = @address, phone = @phone, type = @type, profilePic = @img, sex = @sex, username = @username WHERE id = @staff_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@staff_id", staff_id);
            cmd.Parameters.AddWithValue("@name", staff_name);
            cmd.Parameters.AddWithValue("@address", staff_address);
            cmd.Parameters.AddWithValue("@phone", staff_phone);
            cmd.Parameters.AddWithValue("@type", staff_type);
            cmd.Parameters.AddWithValue("@img", staff_img.ToArray());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@sex", sex);

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;

        }

        public bool deleteEmployee(string staff_id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM staffs WHERE id = @staff_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@staff_id", staff_id);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

        public DataTable getAllEmployees()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM staffs", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getEmployee(string staff_id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM staffs WHERE Id = @staff_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@staff_id", staff_id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
