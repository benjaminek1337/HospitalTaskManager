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
            MockRepository repo = new MockRepository();
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
                .HasForeignKey(sc => sc.StaffID);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Procedures)
                .WithOne(p => p.Department)
                .HasForeignKey(p => p.DepartmentId)
                ;
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Staffs)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                ;

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    ID = 1,
                    DepartmentName = "Coola avdelningen"
                },
                new Department
                {
                    ID = 2,
                    DepartmentName = "Mindre coola avdelningen"
                }
                );

            modelBuilder.Entity<Staff>().HasData(
                repo.GetTodaysStaff()
                );

            modelBuilder.Entity<Procedure>().HasData(
                repo.GetTodaysProcedures()
                );

            modelBuilder.Entity<Schedule>().HasData(
                repo.GetTodaysSchedule()
                );

            modelBuilder.Entity<ScheduledProcedure>().HasData(
                new ScheduledProcedure
                {
                    ProcedureId = 1,
                    ScheduleId = 1,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 1,
                    ScheduleId = 2,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 2,
                    ScheduleId = 2,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 3,
                    ScheduleId = 1,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 4,
                    ScheduleId = 1,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 5,
                    ScheduleId = 3,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 7,
                    ScheduleId = 6,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 5,
                    ScheduleId = 5,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 10,
                    ScheduleId = 8,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 8,
                    ScheduleId = 7,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 7,
                    ScheduleId = 7,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 9,
                    ScheduleId = 8,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 10,
                    ScheduleId = 11,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 11,
                    ScheduleId = 12,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 13,
                    ScheduleId = 13,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 14,
                    ScheduleId = 14,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 15,
                    ScheduleId = 15,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 16,
                    ScheduleId = 16,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 17,
                    ScheduleId = 17,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 18,
                    ScheduleId = 18,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 19,
                    ScheduleId = 19,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 20,
                    ScheduleId = 20,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 21,
                    ScheduleId = 21,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 22,
                    ScheduleId = 22,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 23,
                    ScheduleId = 23,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 24,
                    ScheduleId = 24,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 25,
                    ScheduleId = 25,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 25,
                    ScheduleId = 26,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 26,
                    ScheduleId = 26,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 27,
                    ScheduleId = 27,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 28,
                    ScheduleId = 28,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 29,
                    ScheduleId = 29,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 30,
                    ScheduleId = 30,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 31,
                    ScheduleId = 31,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 32,
                    ScheduleId = 32,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 33,
                    ScheduleId = 33,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 34,
                    ScheduleId = 34,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 35,
                    ScheduleId = 35,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 36,
                    ScheduleId = 37,
                    KeyPerson = true
                },
                new ScheduledProcedure
                {
                    ProcedureId = 37,
                    ScheduleId = 36,
                    KeyPerson = true
                }

                );
               
        }
    }
}
