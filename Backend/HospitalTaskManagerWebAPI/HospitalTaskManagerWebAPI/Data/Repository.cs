using HospitalTaskManagerWebAPI.Models;
using HospitalTaskManagerWebAPI.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
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

        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

        public List<AllDataViewModel> GetInitScheduleData(DateTime date)
        {
            var initdatalist = new List<AllDataViewModel>();
            var initdata = new AllDataViewModel
            {
                Departments = GetDepartments(),
                Procedures = GetTodaysProcedures(date),
                Schedules = GetTodaysSchedule(date),
                ScheduledProcedures = GetTodaysScheduledProcedures(date),
                Staffs = GetTodaysStaff(date)
            }; initdatalist.Add(initdata);
            
            return initdatalist;
        }

        public List<Procedure> GetTodaysProcedures(DateTime date)
        {
            return context.Procedures.Where(p => p.StartDate.Date == date.Date).ToList();
        }

        public List<Schedule> GetTodaysSchedule(DateTime date)
        {
            return context.Schedules.Where(s => s.StartDate.Date == date.Date).ToList();
        }

        public List<ScheduledProcedure> GetTodaysScheduledProcedures(DateTime date)
        {
            return context.ScheduledProcedures.Where(sp => sp.Schedule.StartDate.Date == date.Date).ToList();
        }

        public List<Staff> GetTodaysStaff(DateTime date)
        {
            return context.Staffs.Where(s => s.Schedules.Any(sch => sch.StartDate.Date == date.Date)).ToList();
        }
    }
}
