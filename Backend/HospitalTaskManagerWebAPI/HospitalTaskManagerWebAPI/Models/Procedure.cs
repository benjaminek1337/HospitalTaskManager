using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class Procedure
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public string ProcedureType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<StaffProcedure> StaffProcedures { get; set; }
    }
}
