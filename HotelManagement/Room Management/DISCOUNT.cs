using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management.Room_Management
{
    internal class DISCOUNT
    {
        MyDB mydb = new MyDB();
        

        public DataTable getAllDiscounts()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Discount", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool DiscountExist(string type)
        {

            var exists = mydb.existedKey("Discount", "Type", type);
            if (exists)
            {
                return true;
            }
            return false;

        }
        
        public bool DiscountHandle(string type, int rate)
        {
            //if discount hasn't exist then insert
            //else update it
            
            if (DiscountExist(type))
            {
                return UpdateDiscount(type, rate);
            }
            return insertDiscount(type, rate);
            
        }

        
        public bool UpdateDiscount(string type, int rate)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Discount SET Rate = @rate WHERE Type = @type", mydb.getConnection);
            cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.AddWithValue("@rate", SqlDbType.Int).Value = rate;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public int getLatestID()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 ID FROM Discount ORDER BY ID DESC", mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            mydb.closeConnection();
            return id;
        }


        public bool insertDiscount(string type, int rate)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Discount (Id, Type, Rate) VALUES (@id, @type, @rate)", mydb.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@rate", SqlDbType.Int).Value = rate;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = getLatestID() + 1;
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            return false;
        }

        public bool removeDiscount(string type)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Discount WHERE Type = @type", mydb.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            return false;
        }
        
        public int getDiscount(string type)
        {
            SqlCommand cmd = new SqlCommand("SELECT Rate FROM Discount WHERE Type = @type", mydb.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            mydb.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            int rate = 0;
            if (reader.Read())
            {
                rate = reader.GetInt32(0);
            }
            mydb.closeConnection();
            return rate;
        }


    }
}
