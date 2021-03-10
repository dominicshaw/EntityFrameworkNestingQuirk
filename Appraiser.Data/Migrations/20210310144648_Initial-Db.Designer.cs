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
    [Migration("20210310144648_Initial-Db")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
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

                    b.Property<DateTimeOffset>("PeriodEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("PeriodStart")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Appraisals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Complete = false,
                            Deleted = false,
                            PeriodEnd = new DateTimeOffset(new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            PeriodStart = new DateTimeOffset(new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            StaffId = 3
                        });
                });

            modelBuilder.Entity("Appraiser.Data.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Logon")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SecondaryManagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("SecondaryManagerId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mgr1@company.com",
                            Logon = "mgr1",
                            Name = "Manager 1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mgr2@company.com",
                            Logon = "mgr2",
                            ManagerId = 1,
                            Name = "Manager 2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "emp@company.com",
                            Logon = "emp",
                            ManagerId = 1,
                            Name = "Employee",
                            SecondaryManagerId = 2
                        });
                });

            modelBuilder.Entity("Appraiser.Data.Models.Appraisal", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Staff", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Manager")
                        .WithOne()
                        .HasForeignKey("Appraiser.Data.Models.Staff", "ManagerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Appraiser.Data.Models.Staff", "SecondaryManager")
                        .WithOne()
                        .HasForeignKey("Appraiser.Data.Models.Staff", "SecondaryManagerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manager");

                    b.Navigation("SecondaryManager");
                });
#pragma warning restore 612, 618
        }
    }
}