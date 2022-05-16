using hotel_management.Room_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class ORDER
    {
        MyDB mydb = new MyDB();
        public static int order_id;

        
        public bool insertOrder(order o)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders VALUES (@order_id, @customer_id, @room_id, @order_date, @check_in_date, @check_out_date)", mydb.getConnection);

            cmd.Parameters.AddWithValue("@order_id", SqlDbType.Int).Value = o.order_id;
            cmd.Parameters.AddWithValue("@customer_id", SqlDbType.Int).Value = o.customer_id;
            cmd.Parameters.AddWithValue("@room_id", SqlDbType.Int).Value = o.room_id;
            cmd.Parameters.AddWithValue("@order_date", SqlDbType.DateTime).Value = o.order_date;
            cmd.Parameters.AddWithValue("@check_in_date", SqlDbType.DateTime).Value = o.check_in_date;
            cmd.Parameters.AddWithValue("@check_out_date", SqlDbType.DateTime).Value = o.check_out_date;
            mydb.openConnection();
            
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

        public void getLatestOrderID()
        {
            //SqlCommand cmd = new SqlCommand("SELECT Max(Id) FROM Order HAVING COUNT(*) > 0", mydb.getConnection);
            //check if Id column is empty or null
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY ID DESC", mydb.getConnection);

            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                order_id = Convert.ToInt32(table.Rows[0][0].ToString());
            }
            else
            {
                order_id = 1;
            }
        }
        

        public bool orderExist(int order_id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE Id = @order_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@order_id", SqlDbType.Int).Value = order_id;
            mydb.openConnection();
            if ((int)cmd.ExecuteScalar() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updateOrder(order o)
        {
            SqlCommand cmd = new SqlCommand("update Orders set dCreate=@order_date, dCheckIn=@check_in_date, dCheckOut=@check_out_date, RoomNumber=@room_id, CID=@customer_id where Id=@order_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@order_id", SqlDbType.Int).Value = o.order_id;
            cmd.Parameters.AddWithValue("@order_date", SqlDbType.DateTime).Value = o.order_date;
            cmd.Parameters.AddWithValue("@check_in_date", SqlDbType.DateTime).Value = o.check_in_date;
            cmd.Parameters.AddWithValue("@check_out_date", SqlDbType.DateTime).Value = o.check_out_date;
            cmd.Parameters.AddWithValue("@room_id", SqlDbType.Int).Value = o.room_id;
            cmd.Parameters.AddWithValue("@customer_id", SqlDbType.Int).Value = o.customer_id;
            mydb.openConnection();
            
            if (cmd.ExecuteNonQuery() == 1)
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

        public bool deleteOrder(int order_id)
        {
            SqlCommand cmd = new SqlCommand("delete from Orders where Id=@order_id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@order_id", SqlDbType.Int).Value = order_id;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
            
        public bool newBook(Customer c, order o)
        {
            ORDER ord = new ORDER();
            if (ord.insertOrder(o))
            {
                ROOM room = new ROOM();
                room.updateRoomStatus(o.room_id, 0);

                if (c.insertCustomer())
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            return false;
        }

        public DataTable getAllOrders()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public order getOrderByID(int ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE Id = @ID", mydb.getConnection);
            cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
            mydb.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            order o = new order();
            if (reader.Read())
            {
                o.order_id = Convert.ToInt32(reader["Id"].ToString());
                o.customer_id = Convert.ToInt32(reader["CID"].ToString());
                o.room_id = Convert.ToInt32(reader["RoomNumber"].ToString());
                o.order_date = Convert.ToDateTime(reader["dCreate"].ToString());
                o.check_in_date = Convert.ToDateTime(reader["dCheckIn"].ToString());
                o.check_out_date = Convert.ToDateTime(reader["dCheckOut"].ToString());
            }
            mydb.closeConnection();
            return o;
        }


    }

    internal class order
    {
        public int order_id { get; set; }
        public int room_id { get; set; }
        public int customer_id { get; set; }
        public DateTime order_date { get; set; }
        public DateTime check_in_date { get; set; }
        public DateTime check_out_date { get; set; }
        public int no_of_days { get; set; }

        public order(int room_id, int customer_id, DateTime order_date, DateTime check_in_date, DateTime check_out_date, int no_of_days)
        {
            this.order_id = ORDER.order_id++;
            this.room_id = room_id;
            this.customer_id = customer_id;
            this.order_date = order_date;
            this.check_in_date = check_in_date;
            this.check_out_date = check_out_date;
            this.no_of_days = no_of_days;
        }

        public order()
        {
        }

    }
    
}
