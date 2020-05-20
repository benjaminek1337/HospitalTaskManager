using HospitalTaskManagerWebAPI.Models;
using HospitalTaskManagerWebAPI.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

        public AllDataViewModel GetInitScheduleData(DateTime date)
        {
            var initdata = new AllDataViewModel
            {
                Departments = GetDepartments(),
                Procedures = GetTodaysProcedures(date),
                Schedules = GetTodaysSchedule(date),
                ScheduledProcedures = GetTodaysScheduledProcedures(date),
                Staffs = GetTodaysStaff()
            }; 
            
            return initdata;
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

        public List<Staff> GetTodaysStaff()
        {
            return context.Staffs.ToList();
        }

        public void MarkProcedureAsHandled(Procedure procedure)
        {
            var updatedProcedure = context.Procedures.FirstOrDefault(p => p.ID == procedure.ID);
            updatedProcedure.IsHandled = true;
            context.Update(updatedProcedure);
            context.SaveChanges();
        }

        public void MarkProcedureAsUnhandled(Procedure procedure)
        {
            var updatedProcedure = context.Procedures.FirstOrDefault(p => p.ID == procedure.ID);
            updatedProcedure.IsHandled = false;
            context.Update(updatedProcedure);
            context.SaveChanges();
        }
    }
}
