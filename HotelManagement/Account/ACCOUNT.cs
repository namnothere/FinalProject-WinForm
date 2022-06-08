using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class ACCOUNT
    {
        public string username;
        public string password;

        MyDB mydb = new MyDB();

        public ACCOUNT() { }

        public ACCOUNT(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool usernameExist()
        {
            if (this.username.Trim() == "")
                return false;

            string query = "SELECT * FROM login WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.username;
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }


        public bool usernameExist(string username)
        {
            string query = "SELECT * FROM login WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool login()
        {

            string query = "SELECT * FROM login WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.password;
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = cmd;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


        public int getID(string username)
        {
            string query = "SELECT Id FROM login WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return Convert.ToInt32(table.Rows[0]["Id"].ToString());
            }
            return -1;
        }


        //public bool Available(string username, int id)
        //{
        //    //update include username
        //    //1. không thây đổi username (đang update thông tin khác)
        //    //2. thay đổi username (đang update thông tin của username đó)
        //    string query = "SELECT * FROM staffs WHERE username = @username";
        //    SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

        //    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
        //    mydb.openConnection();

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();

        //    adapter.SelectCommand = cmd;
        //    adapter.Fill(table);

        //    //this username hasn't been taken in staffs table
        //    if (table.Rows.Count == 0)
        //    {
        //        //but did exist in login table (maybe it's a temp account)
        //        if (usernameExist(username) == false)
        //            return true;
        //        return false;
        //    }

        //    //this username belong to this ID
        //    if (table.Rows[0]["usernameID"].ToString() == id.ToString() && table.Rows.Count == 1)
        //    {
        //        return true;
        //    }
        //    else //this username did exist and belong to another ID
        //    {
        //        return false;
        //    }
        //}


        public DataTable getAllAccounts()
        {
            SqlCommand command = new SqlCommand("SELECT Id, username, admin, password FROM login", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool idExist(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            DataTable table = new DataTable();
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool insertAccount(string username, string password, int perm)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO login (username, password, admin) VALUES (@username, @password, @perm)", mydb.getConnection);

            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@perm", SqlDbType.Int).Value = perm;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public Image getImage(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT profilePic FROM staffs WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] data = (byte[])(table.Rows[0]["profilePic"]);
                MemoryStream ms = new MemoryStream(data);
                return Image.FromStream(ms);
            }
            return null;
        }

        public bool updateAccount(string username, string password, int perm)
        {
            SqlCommand cmd = new SqlCommand("UPDATE login SET username = @username, password = @password, admin = @perm WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@perm", SqlDbType.Int).Value = perm;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

        public bool deleteAccount(string username)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM login WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }


        public int admin(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT admin FROM login WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return Convert.ToInt32(table.Rows[0]["admin"].ToString());
            }
            return -1;
        }

        public int admin()
        {
            SqlCommand cmd = new SqlCommand("SELECT admin FROM login WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.username;
            mydb.openConnection();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return Convert.ToInt32(table.Rows[0]["admin"].ToString());
            }
            return -1;
        }

    }
}
