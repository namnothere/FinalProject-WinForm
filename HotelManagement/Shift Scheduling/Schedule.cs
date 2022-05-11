using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hotel_management
{
    internal class Schedule
    {
        DateTime start;
        DateTime end;
        int maxHours;
        List<Requirement> reqNorm = new List<Requirement>();
        List<Requirement> reqSpec = new List<Requirement>();
        
    }
    
    internal class Requirement
    {
        TimeOnly start;
        TimeOnly end;
        int Manager;
        int Receptionist;
        int Cleaner;
    }

}
