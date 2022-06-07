using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hotel_management
{
    internal class Schedule
    {
        DateOnly start;
        DateOnly end;
        int maxHours;
        List<Requirement> reqNorm = new List<Requirement>();
        List<Requirement> reqSpec = new List<Requirement>();
        List<string> specDays = new List<string>();
        List<ShiftInfo> shiftInfos = new List<ShiftInfo>();
        


        public void addReqNorm(List<Requirement> reqNorm)
        {
            this.reqNorm = reqNorm.ToList();
        }

        public void addReqSpec(List<Requirement> reqSpec)
        {
            this.reqSpec = reqSpec.ToList();
        }

        private void addShift(DateTime start, DateTime end, List<Staff> staffs)
        {
            ShiftInfo shift = new ShiftInfo();
            shift.setShiftInfo(start, end, staffs);
            shiftInfos.Add(shift);
        }

        public void createSchedule(DateOnly start, int maxHours, List<Requirement> reqNorm, List<Requirement> reqSpec, List<string> specDays, List<Staff> allStaffs, int workdays)
        {
            this.start = start;
            DateOnly tempEnd1 = start;
            tempEnd1.AddDays(workdays);
            this.end = tempEnd1;
            this.maxHours = maxHours;
            this.reqNorm = reqNorm.ToList();
            this.reqSpec = reqSpec.ToList();

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
            foreach (Staff staff in allStaffs)
            {
                //create normal staff list
                //check exist
                bool exist;
                var matches = staffsList.Where(p => String.Equals(p.type, p.type.Contains(staff.type)));
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
                            List<Staff> staffs = new List<Staff>();
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
                            List<Staff> staffs = new List<Staff>();
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


        internal class Requirement
        {
            public TimeOnly start { get; private set; }
            public TimeOnly end { get; private set; }
            public List<RoleAmount> role = new List<RoleAmount>();
        }

        internal class RoleAmount
        {
            public string roleName;
            public int amount;
        }
    }

    
}
