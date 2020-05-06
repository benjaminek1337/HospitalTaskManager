using HospitalTaskManagerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public interface IRepository
    {
        List<Staff> GetTodaysStaff();
        List<Schedule> GetTodaysSchedule();
        List<Procedure> GetTodaysProcedures();
        List<ScheduledProcedure> GetScheduledProcedures();
    }
}
