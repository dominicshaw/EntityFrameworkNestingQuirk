﻿// <auto-generated />
using System;
using Appraiser.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Appraiser.Data.Migrations
{
    [DbContext(typeof(AppraiserContext))]
    [Migration("20191126170735_Add-Impersonation")]
    partial class AddImpersonation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Appraiser.Data.Models.Appraisal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("FullYearReviewId")
                        .HasColumnType("int");

                    b.Property<int?>("MidYearReviewId")
                        .HasColumnType("int");

                    b.Property<bool>("ObjectivesLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PeriodEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullYearReviewId");

                    b.HasIndex("MidYearReviewId");

                    b.HasIndex("StaffId", "PeriodStart", "Deleted")
                        .IsUnique();

                    b.ToTable("Appraisals");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Change", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("KeyId")
                        .HasColumnType("int");

                    b.Property<string>("New")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Old")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Impersonation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImpersonatesId")
                        .HasColumnType("int");

                    b.Property<int>("ImpersonatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImpersonatesId");

                    b.HasIndex("ImpersonatorId");

                    b.ToTable("Impersonations");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Achieved")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AppraisalId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Measurement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AppraisalId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FCA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NFA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SFC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Responsibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmployeeSignoff")
                        .HasColumnType("datetime2");

                    b.Property<string>("KeySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ManagerSignoff")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleTitle")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Responsibilities");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerNotes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<bool>("IsSuperUser")
                        .HasColumnType("bit");

                    b.Property<string>("Logon")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Appraisal", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Review", "FullYearReview")
                        .WithMany()
                        .HasForeignKey("FullYearReviewId");

                    b.HasOne("Appraiser.Data.Models.Review", "MidYearReview")
                        .WithMany()
                        .HasForeignKey("MidYearReviewId");

                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Impersonation", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Impersonates")
                        .WithMany()
                        .HasForeignKey("ImpersonatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Appraiser.Data.Models.Staff", "Impersonator")
                        .WithMany("Impersonates")
                        .HasForeignKey("ImpersonatorId")
                        .HasConstraintName("FK_Impersonation_Staff_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Objective", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Appraisal", null)
                        .WithMany("Objectives")
                        .HasForeignKey("AppraisalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Registration", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Responsibility", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Staff", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Training", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Review", null)
                        .WithMany("Training")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
