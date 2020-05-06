using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class ScheduledProcedure
    {
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public bool keyPerson { get; set; }
    }
}
