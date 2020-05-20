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
        List<Staff> GetTodaysStaff();
        List<Schedule> GetTodaysSchedule(DateTime date);
        List<Procedure> GetTodaysProcedures(DateTime date);
        List<ScheduledProcedure> GetTodaysScheduledProcedures(DateTime date);
        List<Department> GetDepartments();
        AllDataViewModel GetInitScheduleData(DateTime date);
        void MarkProcedureAsHandled(Procedure procedure);
        void MarkProcedureAsUnhandled(Procedure procedure);
    }
}
