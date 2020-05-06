using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class Procedure
    {
        public int ID { get; set; }
        public int DepartmentId { get; set; }
        public string ProcedureName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<ScheduledProcedure> ScheduledProcedures { get; set; }
    }
}
