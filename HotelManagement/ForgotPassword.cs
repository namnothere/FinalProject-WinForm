using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class ForgotPassword
    {
        MyDB mydb = new MyDB();

        public bool existedUsername(string username)
        {
            SqlCommand myCommand = new SqlCommand("Select * from login where Username= @Username", mydb.getConnection);
            myCommand.Parameters.AddWithValue("@Username", username);
            DataTable table = new DataTable();
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = myCommand;
            adapter.Fill(table);


            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Forgot(string username)
        {

            SqlCommand myCommand = new SqlCommand("Select password from login where Username= @Username", mydb.getConnection);
            myCommand.Parameters.AddWithValue("@Username", username);
            string pw = "";
            mydb.openConnection();

            SqlDataReader read = myCommand.ExecuteReader();

            if (read.Read())
            {
                pw = read["password"].ToString();
                return pw;
            }
            return pw;
            mydb.closeConnection();
        }
    }
}
