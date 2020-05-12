using HospitalTaskManagerWebAPI.Models;
using HospitalTaskManagerWebAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTaskManagerWebAPI.Data
{
    public interface IRepository
    {
        List<Staff> GetTodaysStaff(DateTime date);
        List<Schedule> GetTodaysSchedule(DateTime date);
        List<Procedure> GetTodaysProcedures(DateTime date);
        List<ScheduledProcedure> GetTodaysScheduledProcedures(DateTime date);
        List<Department> GetDepartments();
        List<AllDataViewModel> GetInitScheduleData(DateTime date);
    }
}
