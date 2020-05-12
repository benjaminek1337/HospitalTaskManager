using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Models.ViewModels
{
    public class AllDataViewModel
    {
        public List<Department> Departments { get; set; }
        public List<Procedure> Procedures { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<ScheduledProcedure> ScheduledProcedures { get; set; }
        public List<Staff> Staffs { get; set; }

        public AllDataViewModel()
        {
            Departments = new List<Department>();
            Procedures = new List<Procedure>();
            Schedules = new List<Schedule>();
            ScheduledProcedures = new List<ScheduledProcedure>();
            Staffs = new List<Staff>();

        }
    }
}
