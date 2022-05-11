using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class NEW_ACCOUNT
    {
        MyDB mydb = new MyDB();

        public bool insertNewAccount(string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (username, password)"
                    + " VALUES (@username, @password)", mydb.getConnection);

            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        

    }
}
