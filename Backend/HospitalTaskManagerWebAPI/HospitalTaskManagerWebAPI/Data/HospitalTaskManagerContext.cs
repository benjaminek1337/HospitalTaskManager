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

        public DbSet<AccessLog> AccessLog { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffProcedure> StaffProcedure { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffProcedure>()
                .HasKey(sp => new { sp.StaffID, sp.ProcedureID });
            modelBuilder.Entity<StaffProcedure>()
                .HasOne(sp => sp.Staff)
                .WithMany(s => s.StaffProcedures)
                .HasForeignKey(sp => sp.StaffID);
            modelBuilder.Entity<StaffProcedure>()
                .HasOne(sp => sp.Procedure)
                .WithMany(s => s.StaffProcedures)
                .HasForeignKey(sp => sp.ProcedureID);
        }
    }
}
