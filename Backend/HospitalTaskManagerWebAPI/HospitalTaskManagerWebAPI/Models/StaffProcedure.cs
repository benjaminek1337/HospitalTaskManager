using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models
{
    public class StaffProcedure
    {
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
        public int ProcedureID { get; set; }
        public Procedure Procedure { get; set; }
    }
}
