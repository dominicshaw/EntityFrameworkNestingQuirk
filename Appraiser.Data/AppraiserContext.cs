using System;
using Appraiser.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Appraiser.Data
{
    public class AppraiserContext : DbContext
    {
        public DbSet<Appraisal> Appraisals { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Impersonation> Impersonations { get; set; }
        public DbSet<EmergencyContacts> EmergencyContacts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Breach> Breaches { get; set; }

        public DbSet<Fitness> FitnessForms { get; set; }
        public DbSet<FitnessQuestion> FitnessQuestions { get; set; }
        public DbSet<FitnessAnswer> FitnessAnswers { get; set; }

        public DbSet<Change> Changes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ROMHSQL01\\TEST01;Initial Catalog=EntityFrameworkNestingQuirk;Trusted_Connection=True;App=EntityFrameworkNestingQuirk;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Appraisal>()
                .HasIndex(u => new { u.StaffId, u.PeriodStart, u.Deleted })
                .IsUnique();

            builder.Entity<Impersonation>()
                .HasOne(i => i.Impersonator)
                .WithMany(s => s.Impersonates)
                .HasForeignKey(i => i.ImpersonatorId)
                .HasConstraintName("FK_Impersonation_Staff_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Staff>().HasKey(s => s.Id);
            builder.Entity<Staff>().HasIndex(e => e.ManagerId).IsUnique(false);
            builder.Entity<Staff>()
                .HasOne(a => a.Manager)
                .WithOne()
                .HasForeignKey<Staff>(s => s.ManagerId)
                .HasConstraintName("FK_Staff_Primary_Manager")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Staff>().HasIndex(e => e.SecondaryManagerId).IsUnique(false);
            builder.Entity<Staff>()
                .HasOne(a => a.SecondaryManager)
                .WithOne()
                .HasForeignKey<Staff>(s => s.SecondaryManagerId)
                .HasConstraintName("FK_Staff_Secondary_Manager")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Staff>().HasData(
                new Staff { Id = 1, Email = "mgr1@company.com", Logon = "mgr1", Name = "Manager 1" }
            );

            builder.Entity<Staff>().HasData(
                new Staff { Id = 2, Email = "mgr2@company.com", Logon = "mgr2", Name = "Manager 2", ManagerId = 1 },
                new Staff { Id = 3, Email = "emp@company.com", Logon = "emp", Name = "Employee", ManagerId = 1, SecondaryManagerId = 2 }
            );

            builder.Entity<Appraisal>().HasData(new Appraisal()
            {
                Id = 1,
                PeriodStart = new DateTimeOffset(new DateTime(2020, 1, 1).ToUniversalTime()),
                PeriodEnd = new DateTimeOffset(new DateTime(2020, 12, 31).ToUniversalTime()),
                StaffId = 3
            });
        }
    }
}