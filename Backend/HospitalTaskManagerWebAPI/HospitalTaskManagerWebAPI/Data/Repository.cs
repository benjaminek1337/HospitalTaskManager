using HospitalTaskManagerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly HospitalTaskManagerContext context;
        public Repository(HospitalTaskManagerContext context)
        {
            this.context = context;
        }

        public List<ScheduledProcedure> GetScheduledProcedures()
        {
            throw new NotImplementedException();
        }

        public List<Procedure> GetTodaysProcedures()
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetTodaysSchedule()
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetTodaysStaff()
        {
            throw new NotImplementedException();
        }
    }
}
