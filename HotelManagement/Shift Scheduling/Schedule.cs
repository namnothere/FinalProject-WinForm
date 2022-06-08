using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace hotel_management
{
    internal class Schedule
    {
        MyDB mydb = new MyDB();

        List<ShiftInfo> shiftInfos = new List<ShiftInfo>();

        private void addShift(DateTime start, DateTime end, List<STAFF> staffs)
        {
            ShiftInfo shift = new ShiftInfo();
            shift.setShiftInfo(start, end, staffs);
            shiftInfos.Add(shift);
        }

        public void createSchedule(DateOnly start, int maxHours, List<Requirement> reqNorm, List<Requirement> reqSpec, List<string> specDays, List<STAFF> allStaffs, int workdays)
        {

            //create lists of staffs in roles
            List<StaffList> staffsList = new List<StaffList>();
            //add list of roles
            foreach (Requirement req in reqNorm)
            {
                foreach (RoleAmount role in req.role)
                {
                    bool exist;
                    var matches = staffsList.Where(p => String.Equals(p.type, role.roleName, StringComparison.CurrentCulture));
                    exist = matches.Count() > 0;

                    if (!exist)
                    {
                        staffsList.Add(new StaffList { type = role.roleName });
                    }
                }

            }

            //add list of roles (special days)
            foreach (Requirement req in reqSpec)
            {
                foreach (RoleAmount role in req.role)
                {
                    bool exist;
                    var matches = staffsList.Where(p => String.Equals(p.type, role.roleName, StringComparison.CurrentCulture));
                    exist = matches.Count() > 0;

                    if (!exist)
                    {
                        staffsList.Add(new StaffList { type = role.roleName });
                    }
                }

            }

            //add staffs to each role
            foreach (STAFF staff in allStaffs)
            {
                //create normal staff list
                //check exist
                bool exist;
                var matches = staffsList.Where(p => String.Equals(p.type, p.type.Contains(staff.staff_type)));
                exist = matches.Count() > 0;
                if (exist)
                {
                    foreach (StaffList comb in matches)
                    {
                        comb.staffs.Add(staff);
                    }
                }
            }

            //staff distributing on time table
            DateOnly today = start;
            List<int> indexes = new List<int>();
            foreach (StaffList list in staffsList)
            {
                indexes.Add(0);
            }
            for (int i = 0; i < workdays; i++)
            {
                //check if today is special day
                bool spec;
                var matches = specDays.Where(p => String.Equals(p, today.DayOfWeek.ToString(), StringComparison.CurrentCulture));
                spec = matches.Count() > 0;
                //normal day
                if (!spec)
                {
                    //add shifts according to the normal requirement
                    for (int j = 0; j < reqNorm.Count(); j++)
                    {
                        DateTime ShiftStart = today.ToDateTime(reqNorm[j].start);
                        //hours remaining of shift span
                        TimeSpan leftover = reqNorm[j].end - reqNorm[j].start;
                        bool first = true;
                        DateTime ShiftEnd = new DateTime();
                        while (leftover.TotalHours > 0)
                        {
                            //declaring start and end time
                            if (!first)
                            {
                                //continue from last shift
                                ShiftStart = ShiftEnd;
                            }
                            TimeOnly tempEnd = TimeOnly.FromDateTime(ShiftStart);

                            if (leftover.TotalHours > maxHours)
                            {
                                tempEnd.AddHours(maxHours);
                                ShiftEnd = today.ToDateTime(tempEnd);
                                leftover -= TimeSpan.FromHours(maxHours);
                            }
                            else
                            {
                                tempEnd.AddHours(leftover.TotalHours);
                                ShiftEnd = today.ToDateTime(tempEnd);
                                leftover -= leftover;
                            }
                            first = false;

                            //assigning staffs
                            List<STAFF> staffs = new List<STAFF>();
                            foreach (RoleAmount role in reqNorm[j].role)
                            {
                                for (int k = 0; k < role.amount; k++)
                                {
                                    int index = staffsList.FindIndex(p => p.type == role.roleName);
                                    staffs.Add(staffsList[index].staffs[indexes[index]]);
                                    //check if at end of staff list to roll back to the first one, else increase by one
                                    if (indexes[index] == staffsList[index].staffs.Count - 1)
                                    {
                                        indexes[index] = 0;
                                    }
                                    else
                                    {
                                        indexes[index]++;
                                    }
                                }
                            }
                            //add shift
                            addShift(ShiftStart, ShiftEnd, staffs);
                        }
                    }
                }
                else
                {
                    //add shifts according to the special requirement
                    for (int j = 0; j < reqSpec.Count(); j++)
                    {
                        DateTime ShiftStart = today.ToDateTime(reqSpec[j].start);
                        //hours remaining of shift span
                        TimeSpan leftover = reqSpec[j].end - reqSpec[j].start;
                        bool first = true;
                        DateTime ShiftEnd = new DateTime();
                        while (leftover.TotalHours > 0)
                        {
                            //declaring start and end time
                            if (!first)
                            {
                                //continue from last shift
                                ShiftStart = ShiftEnd;
                            }
                            TimeOnly tempEnd = TimeOnly.FromDateTime(ShiftStart);

                            if (leftover.TotalHours > maxHours)
                            {
                                tempEnd.AddHours(maxHours);
                                ShiftEnd = today.ToDateTime(tempEnd);
                                leftover -= TimeSpan.FromHours(maxHours);
                            }
                            else
                            {
                                tempEnd.AddHours(leftover.TotalHours);
                                ShiftEnd = today.ToDateTime(tempEnd);
                                leftover -= leftover;
                            }
                            first = false;

                            //assigning staffs
                            List<STAFF> staffs = new List<STAFF>();
                            foreach (RoleAmount role in reqSpec[j].role)
                            {
                                for (int k = 0; k < role.amount; k++)
                                {
                                    int index = staffsList.FindIndex(p => p.type == role.roleName);
                                    staffs.Add(staffsList[index].staffs[indexes[index]]);
                                    //check if at end of staff list to roll back to the first one, else increase by one
                                    if (indexes[index] == staffsList[index].staffs.Count - 1)
                                    {
                                        indexes[index] = 0;
                                    }
                                    else
                                    {
                                        indexes[index]++;
                                    }
                                }
                            }

                            //add shift
                            addShift(ShiftStart, ShiftEnd, staffs);
                        }
                    }
                }
                today = today.AddDays(1);
            }
        }

        public DataTable toDataTable()
        {
            DataTable dt = new DataTable();
            if (shiftInfos.Count > 0)
            {
                DateOnly today = DateOnly.FromDateTime(shiftInfos[0].getStart());
                bool first = true;
                dt.Columns.Add("Time start", typeof(TimeOnly));
                dt.Columns.Add("Time end", typeof(TimeOnly));
                dt.Columns.Add(today.ToString(), typeof(string));
                int index = 0;
                foreach (ShiftInfo shiftInfo in shiftInfos)
                {
                    if (DateOnly.FromDateTime(shiftInfo.getStart()) == today && first == true)
                    {
                        DataRow row = dt.NewRow();
                        row[0] = TimeOnly.FromDateTime(shiftInfo.getStart());
                        row[1] = TimeOnly.FromDateTime(shiftInfo.getEnd());
                        string names = "";
                        foreach (STAFF staff in shiftInfo.getStaffs())
                        {
                            names += staff.staff_name + "\n";
                        }
                        names.Trim('\n');
                        row[2] = names;
                        dt.Rows.Add(row);
                    }
                    else if (DateOnly.FromDateTime(shiftInfo.getStart()) != today)
                    {
                        index = 0;
                        today = DateOnly.FromDateTime(shiftInfo.getStart());
                        dt.Columns.Add(today.ToString(), typeof(string));
                        string names = "";
                        foreach (STAFF staff in shiftInfo.getStaffs())
                        {
                            names += staff.staff_name + ", ";
                        }
                        dt.Rows[index][dt.Columns.Count - 1] = names;
                        index++;
                    }
                    else if (DateOnly.FromDateTime(shiftInfo.getStart()) == today)
                    {
                        string names = "";
                        foreach (STAFF staff in shiftInfo.getStaffs())
                        {
                            names += staff.staff_name + ", ";
                        }
                        dt.Rows[index][dt.Columns.Count - 1] = names;
                        index++;
                    }
                }
            }
            return dt;
        }

        public bool insertDatabase()
        {
            foreach (ShiftInfo info in shiftInfos)
            {
                DateTime start = info.getStart();
                DateTime end = info.getEnd();
                string id = "";
                foreach (STAFF staff in info.getStaffs())
                {
                    id += staff.staff_id + " ";
                }
                id.Trim();
                SqlCommand cmd = new SqlCommand("INSERT INTO schedule VALUES(@Start, @End, @StaffIDs)", mydb.getConnection);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.Parameters.AddWithValue("@staffids", id);
                mydb.openConnection();
                if (cmd.ExecuteNonQuery() != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public void retrieveDatabase()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM schedule", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow dr in table.Rows)
            {
                DateTime start = Convert.ToDateTime(dr["Start"]);
                DateTime end = Convert.ToDateTime(dr["End"]);
                List<STAFF> staffs = new List<STAFF>();
                foreach (int id in separateIDs(dr["StaffIDs"].ToString()))
                {
                    STAFF staff = new STAFF();

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM staffs WHERE Id = @staff_id", mydb.getConnection);
                    cmd.Parameters.AddWithValue("@staff_id", id);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string name = table2.Rows[0]["name"].ToString();
                        string dob = table2.Rows[0]["dob"].ToString();
                        string address = table2.Rows[0]["address"].ToString();
                        string phone = table2.Rows[0]["phone"].ToString();
                        string sex = table2.Rows[0]["sex"].ToString();
                        string type = table2.Rows[0]["type"].ToString();
                        byte[] pic;
                        pic = (byte[])table2.Rows[0]["profilePic"];
                        MemoryStream picture = new MemoryStream(pic);
                        Image img = Image.FromStream(picture);
                        string usernameID = table2.Rows[0]["usernameID"].ToString();
                        staff.setStaff(id.ToString(), name, dob, address, phone, sex, type, img, usernameID);
                        staffs.Add(staff);
                    }
                }
                addShift(start, end, staffs);
            }
        }

        private List<int> separateIDs(string ids)
        {
            List<int> list = new List<int>();
            string[] separated = ids.Split(' ');
            for (int i = 0; i < separated.Length; i++)
            {
                list.Add(Convert.ToInt16(separated[i]));
            }
            return list;

        }
    }

    internal class Requirement
    {
        public TimeOnly start { get; set; }
        public TimeOnly end { get; set; }
        public List<RoleAmount> role = new List<RoleAmount>();
    }

    internal class RoleAmount
    {
        public string roleName;
        public int amount;
    }


}
