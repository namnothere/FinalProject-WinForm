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

        public ACCOUNT()
        {
        }
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

        public DataTable getAllAccounts()
        {
            SqlCommand command = new SqlCommand("SELECT Id, username FROM login", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
