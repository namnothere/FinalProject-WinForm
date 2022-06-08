using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management
{
    internal class ATTENDANCE
    {
        MyDB mydb = new MyDB();
        
        public DataTable getStaffAttendance(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM attendance WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public DataTable getStaffAttendanceInRange(int id, DateTime start, DateTime end)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM attendance WHERE Id = @id AND start BETWEEN @start AND @endT", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@endT", end);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool addAttendance(int id)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO attendance VALUES(@id, @start, @endT, @STT, @duration, @date)", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@start", DBNull.Value);
            cmd.Parameters.AddWithValue("@endT", DBNull.Value);
            cmd.Parameters.AddWithValue("@duration", DBNull.Value);
            cmd.Parameters.AddWithValue("@date", DBNull.Value);
            cmd.Parameters.Add("@STT", SqlDbType.Int).Value = getLatestSTT() + 1;
            
            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public bool startShift(int id, DateTime start)
        {
            //update sql 

            SqlCommand cmd = new SqlCommand("UPDATE attendance SET start = @start, date = @start WHERE Id = @id", mydb.getConnection);

            //SqlCommand cmd = new SqlCommand("UPDATE attendance VALUES(@id, @start, @end)");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@start", start);
            

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public bool endShift(int id, DateTime end)
        {
            //SqlCommand cmd = new SqlCommand("INSERT INTO attendance VALUES(@id, @start, @end)");
            SqlCommand cmd = new SqlCommand("UPDATE attendance SET endT = @endT, duration = @duration WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@endT", end);
            TimeSpan span = end - getStart(id);
            cmd.Parameters.AddWithValue("@duration", Math.Round(span.TotalMinutes, 2).ToString());
            //cmd.Parameters.AddWithValue("@time", end);

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public DateTime getStart(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT start FROM attendance WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToDateTime(table.Rows[table.Rows.Count - 1]["start"]);
        }

        public DateTime getEnd(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT endT FROM attendance WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToDateTime(table.Rows[table.Rows.Count - 1]["endT"]);
        }

        public int getLatestSTT()
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", mydb.getConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //return table;
            
            SqlCommand cmd = new SqlCommand("SELECT MAX(STT) FROM attendance", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows[0][0] == DBNull.Value)
                return -1;
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public bool AttendanceAvailable(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM attendance WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            //if the last row is not fully fill with start and end
            //that's mean the shift is not finished
            //therefore new shift can not be started

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[table.Rows.Count - 1];
                if (row["endT"].ToString() == "" || row["start"].ToString() == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

    }
}
