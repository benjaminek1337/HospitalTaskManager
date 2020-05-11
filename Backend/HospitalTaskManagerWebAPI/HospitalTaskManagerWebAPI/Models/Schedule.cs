using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<ScheduledProcedure> ScheduledProcedures { get; set; }
    }
}
