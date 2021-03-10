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
    [Migration("20210218094405_Fitness-Question-Text-Size-2000")]
    partial class FitnessQuestionTextSize2000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
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

                    b.Property<DateTimeOffset>("PeriodEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("PeriodStart")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullYearReviewId");

                    b.HasIndex("MidYearReviewId");

                    b.HasIndex("StaffId", "PeriodStart", "Deleted")
                        .IsUnique();

                    b.ToTable("Appraisals");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Breach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Breaches");
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

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Table")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DayPhone")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("EmergencyContactsId")
                        .HasColumnType("int");

                    b.Property<string>("EveningPhone")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Middlename")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EmergencyContactsId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Appraiser.Data.Models.EmergencyContacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("EmergencyContacts");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Fitness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssessedId")
                        .HasColumnType("int");

                    b.Property<string>("AssessmentType")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("AssessorId")
                        .HasColumnType("int");

                    b.Property<string>("AssessorRole")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool?>("CertificateProvided")
                        .HasColumnType("bit");

                    b.Property<string>("CompetenceAssessed")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("ComplianceSignoffAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ComplianceSignoffBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ComplianceSignoffNotes")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FinancesAssessed")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("HonestyAssessed")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("HrSignoffAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("HrSignoffBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("HrSignoffNotes")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool?>("ImposedLimitations")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ManagerSignoffAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManagerSignoffBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ManagerSignoffNotes")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("NextAssessmentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("PassCriteria")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool?>("SupportingEvidence")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AssessedId");

                    b.HasIndex("AssessorId");

                    b.ToTable("FitnessForms");
                });

            modelBuilder.Entity("Appraiser.Data.Models.FitnessAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Answer")
                        .HasColumnType("bit");

                    b.Property<int>("FitnessId")
                        .HasColumnType("int");

                    b.Property<int>("FitnessQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("FitnessId");

                    b.HasIndex("FitnessQuestionId");

                    b.ToTable("FitnessAnswers");
                });

            modelBuilder.Entity("Appraiser.Data.Models.FitnessQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("SectionNumber")
                        .HasColumnType("int");

                    b.Property<string>("Subsection")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("FitnessQuestions");
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

                    b.Property<string>("Manager2Notes")
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

                    b.Property<bool>("IsFitAndProper")
                        .HasColumnType("bit");

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

                    b.Property<int?>("SecondaryManagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("SecondaryManagerId");

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

            modelBuilder.Entity("Appraiser.Data.Models.Breach", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Change", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("Appraiser.Data.Models.Contact", b =>
                {
                    b.HasOne("Appraiser.Data.Models.EmergencyContacts", "EmergencyContacts")
                        .WithMany("Contacts")
                        .HasForeignKey("EmergencyContactsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.EmergencyContacts", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Appraiser.Data.Models.Fitness", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Staff", "Assessed")
                        .WithMany()
                        .HasForeignKey("AssessedId");

                    b.HasOne("Appraiser.Data.Models.Staff", "Assessor")
                        .WithMany()
                        .HasForeignKey("AssessorId");
                });

            modelBuilder.Entity("Appraiser.Data.Models.FitnessAnswer", b =>
                {
                    b.HasOne("Appraiser.Data.Models.Fitness", "Fitness")
                        .WithMany("Answers")
                        .HasForeignKey("FitnessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Appraiser.Data.Models.FitnessQuestion", "FitnessQuestion")
                        .WithMany()
                        .HasForeignKey("FitnessQuestionId")
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
                        .WithOne()
                        .HasForeignKey("Appraiser.Data.Models.Staff", "ManagerId")
                        .HasConstraintName("FK_Staff_Primary_Manager")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Appraiser.Data.Models.Staff", "SecondaryManager")
                        .WithOne()
                        .HasForeignKey("Appraiser.Data.Models.Staff", "SecondaryManagerId")
                        .HasConstraintName("FK_Staff_Secondary_Manager")
                        .OnDelete(DeleteBehavior.NoAction);
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
