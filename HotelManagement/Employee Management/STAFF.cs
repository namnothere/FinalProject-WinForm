using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    public class STAFF
    {
        public string staff_id { get; private set; }
        public string staff_name { get; private set; }
        private string staff_dob;
        private string staff_address;
        private string staff_phone;
        private string staff_sex;
        public string staff_type { get; private set; }
        private Image staff_img;
        private string staff_usernameID;

        MyDB mydb = new MyDB();

        public void setStaff(string id, string name, string dob, string address, string phone, string sex, string type, Image img, string usernameID)
        {
            staff_id = id;
            staff_name = name;
            staff_dob = dob;
            staff_address = address;
            staff_phone = phone;
            staff_sex = sex;
            staff_type = type;
            staff_img = img;
            staff_usernameID = usernameID;
        }

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


        public bool insertEmployee(string staff_id, string staff_name, DateTime DOB, string staff_address, string staff_phone, string staff_type, string username, MemoryStream staff_img)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO staffs VALUES(@Id, @name, @DOB, @address, @phone, @type, @username, @img)", mydb.getConnection);

            cmd.Parameters.AddWithValue("@Id", staff_id);
            cmd.Parameters.AddWithValue("@name", staff_name);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@address", staff_address);
            cmd.Parameters.AddWithValue("@phone", staff_phone);
            cmd.Parameters.AddWithValue("@type", staff_type);
            cmd.Parameters.AddWithValue("@img", staff_img.ToArray());
            cmd.Parameters.AddWithValue("@username", username);

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }



        public bool updateEmployee(string staff_id, string staff_name, DateTime DOB, string staff_address, string staff_phone, string staff_type, string username, MemoryStream staff_img)
        {
            SqlCommand cmd = new SqlCommand("UPDATE STAFF SET staff_name = @staff_name, staff_address = @staff_address, staff_phone = @staff_phone, staff_type = @staff_type, staff_img = @staff_img WHERE staff_id = @staff_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@Id", staff_id);
            cmd.Parameters.AddWithValue("@name", staff_name);
            cmd.Parameters.AddWithValue("@address", staff_address);
            cmd.Parameters.AddWithValue("@phone", staff_phone);
            cmd.Parameters.AddWithValue("@type", staff_type);
            cmd.Parameters.AddWithValue("@img", staff_img.ToArray());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;

        }

        public bool deleteEmployee(string staff_id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM STAFF WHERE staff_id = @staff_id", mydb.getConnection);
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

        public void convertStaff(DataRow row)
        {
            staff_id = row[0].ToString();
            staff_name = row[1].ToString();
            staff_dob = row[2].ToString();
            staff_address = row[3].ToString();
            staff_phone = row[4].ToString();
            staff_sex = row[5].ToString();
            staff_type = row[6].ToString();
            byte[] pic;
            pic = (byte[])row[7];
            MemoryStream picture = new MemoryStream(pic);
            staff_img = Image.FromStream(picture);
            staff_usernameID = row[8].ToString();
        }
    }
}
