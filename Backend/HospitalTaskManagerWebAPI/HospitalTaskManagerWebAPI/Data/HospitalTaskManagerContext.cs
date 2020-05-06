using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalTaskManagerWebAPI.Models;

namespace HospitalTaskManagerWebAPI.Data
{
    public class HospitalTaskManagerContext : DbContext
    {
        public HospitalTaskManagerContext (DbContextOptions<HospitalTaskManagerContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ScheduledProcedure> StaffProcedures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduledProcedure>()
                .HasKey(sp => new { sp.ScheduleId, sp.ProcedureId });
            modelBuilder.Entity<ScheduledProcedure>()
                .HasOne(sp => sp.Schedule)
                .WithMany(s => s.ScheduledProcedures)
                .HasForeignKey(sp => sp.ScheduleId);
            modelBuilder.Entity<ScheduledProcedure>()
                .HasOne(sp => sp.Procedure)
                .WithMany(s => s.ScheduledProcedures)
                .HasForeignKey(sp => sp.ProcedureId);
        }
    }
}
