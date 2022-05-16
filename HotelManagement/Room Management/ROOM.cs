using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management.Room_Management
{
    internal class ROOM
    {
        MyDB mydb = new MyDB();

        public room getRoomByNumber(int roomNumber)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE roomNo = @roomNumber", mydb.getConnection);
            cmd.Parameters.AddWithValue("@roomNumber", SqlDbType.Int).Value = roomNumber;
            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                room room = new room(table);
                return room;
            }
            return null;

        }

        public bool roomExist(int roomNumber)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE roomNo = @roomNumber", mydb.getConnection);
            cmd.Parameters.AddWithValue("@roomNumber", SqlDbType.Int).Value = roomNumber;
            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool getRoomStatus(int roomNumber)
        {
            //true if that room is free
            room room = getRoomByNumber(roomNumber);
            if (room.roomStatus == 1)
                return true;
            return false;
        }

        public string getRoomType(int roomNumber)
        {
            room room = getRoomByNumber(roomNumber);
            return room.roomType;
        }

        public double getRoomPrice(int roomNumber)
        {
            room room = getRoomByNumber(roomNumber);
            return room.roomPrice;
        }

        public bool updateRoom(int roomNumber, string roomType, double roomPrice, int roomStatus)
        {
            //put empty string if you don't want to change it
            if (roomType == "")
                roomType = getRoomType(roomNumber);
            if (roomPrice == 0)
                roomPrice = getRoomPrice(roomNumber);
            if (roomStatus == -1)
            {
                if (getRoomStatus(roomNumber))
                    roomStatus = 1;
                else
                    roomStatus = 0;

            }

            SqlCommand cmd = new SqlCommand("UPDATE room SET type = @roomType, price = @roomPrice, available = @roomStatus WHERE roomNo = @roomNumber", mydb.getConnection);
            mydb.openConnection();
            cmd.Parameters.AddWithValue("@roomNumber", SqlDbType.Int).Value = roomNumber;
            cmd.Parameters.AddWithValue("@roomType", SqlDbType.NVarChar).Value = roomType;
            cmd.Parameters.AddWithValue("@roomPrice", SqlDbType.Float).Value = (float)roomPrice;
            cmd.Parameters.AddWithValue("@roomStatus", SqlDbType.Int).Value = roomStatus;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            return false;
        }


        public bool updateRoomStatus(int roomNumber, int roomStatus)
        {

            SqlCommand cmd = new SqlCommand("UPDATE room SET available = @roomStatus WHERE roomNo = @roomNumber", mydb.getConnection);
            cmd.Parameters.AddWithValue("@roomNumber", SqlDbType.Int).Value = roomNumber;
            cmd.Parameters.AddWithValue("@roomStatus", SqlDbType.Int).Value = roomStatus;
            mydb.openConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                return true;
            }
            return false;
        }

        public DataTable getAllRooms()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM room", mydb.getConnection);
            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        
        public DataTable getRoomByType(string type)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM room WHERE type = @roomType", mydb.getConnection);
            cmd.Parameters.Add("@roomType", SqlDbType.NVarChar).Value = type;
            mydb.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }


    }

    internal class room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public double roomPrice { get; set; }
        public int roomStatus { get; set; }
        
        public room(DataTable table)
        {
            roomNumber = Convert.ToInt32(table.Rows[0]["roomNo"]);

            roomType = table.Rows[0]["type"].ToString();

            roomStatus = Convert.ToInt32(table.Rows[0]["available"]);

            roomPrice = Convert.ToDouble(table.Rows[0]["price"]);
           
        }
        
    }
    
    
}
