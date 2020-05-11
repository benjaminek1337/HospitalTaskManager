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
        public DbSet<ScheduledProcedure> ScheduledProcedures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScheduledProcedure>()
                .HasKey(sp => new { sp.ScheduleId, sp.ProcedureId });
            modelBuilder.Entity<ScheduledProcedure>()
                .HasOne(sp => sp.Schedule)
                .WithMany(s => s.ScheduledProcedures)
                .HasForeignKey(sp => sp.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ScheduledProcedure>()
                .HasOne(sp => sp.Procedure)
                .WithMany(s => s.ScheduledProcedures)
                .HasForeignKey(sp => sp.ProcedureId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Staff>()
                .HasMany(s => s.Schedules)
                .WithOne(sc => sc.Staff)
                .HasForeignKey(s => s.StaffID);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Procedures)
                .WithOne(p => p.Department)
                .HasForeignKey(p => p.DepartmentId);
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Staffs)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId);

        }
    }
}
