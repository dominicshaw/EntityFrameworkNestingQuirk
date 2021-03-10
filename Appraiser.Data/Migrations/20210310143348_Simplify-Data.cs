using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class SimplifyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appraisals_Reviews_FullYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Appraisals_Reviews_MidYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Primary_Manager",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Secondary_Manager",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Breaches");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FitnessAnswers");

            migrationBuilder.DropTable(
                name: "Impersonations");

            migrationBuilder.DropTable(
                name: "Objectives");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "FitnessForms");

            migrationBuilder.DropTable(
                name: "FitnessQuestions");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_FullYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_MidYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropColumn(
                name: "FullYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropColumn(
                name: "MidYearReviewId",
                table: "Appraisals");

            migrationBuilder.DropColumn(
                name: "ObjectivesLocked",
                table: "Appraisals");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Staff_ManagerId",
                table: "Staff",
                column: "ManagerId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Staff_SecondaryManagerId",
                table: "Staff",
                column: "SecondaryManagerId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Staff_ManagerId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Staff_SecondaryManagerId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "FullYearReviewId",
                table: "Appraisals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MidYearReviewId",
                table: "Appraisals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ObjectivesLocked",
                table: "Appraisals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Breaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breaches_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContacts_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitnessForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessedId = table.Column<int>(type: "int", nullable: true),
                    AssessedSignoffAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssessedSignoffBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssessedSignoffNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AssessmentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssessorId = table.Column<int>(type: "int", nullable: true),
                    AssessorRole = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssessorSignoffAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssessorSignoffBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssessorSignoffNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CertificateProvided = table.Column<bool>(type: "bit", nullable: true),
                    CompetenceAssessed = table.Column<int>(type: "int", nullable: true),
                    ComplianceSignoffAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComplianceSignoffBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ComplianceSignoffNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinancesAssessed = table.Column<int>(type: "int", nullable: true),
                    HonestyAssessed = table.Column<int>(type: "int", nullable: true),
                    HrSignoffAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HrSignoffBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HrSignoffNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImposedLimitations = table.Column<bool>(type: "bit", nullable: true),
                    NextAssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassCriteria = table.Column<bool>(type: "bit", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SupportingEvidence = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitnessForms_Staff_AssessedId",
                        column: x => x.AssessedId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FitnessForms_Staff_AssessorId",
                        column: x => x.AssessorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FitnessQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SectionNumber = table.Column<int>(type: "int", nullable: false),
                    Subsection = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Impersonations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpersonatesId = table.Column<int>(type: "int", nullable: false),
                    ImpersonatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impersonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Impersonation_Staff_Id",
                        column: x => x.ImpersonatorId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Impersonations_Staff_ImpersonatesId",
                        column: x => x.ImpersonatesId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Achieved = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AppraisalId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objectives_Appraisals_AppraisalId",
                        column: x => x.AppraisalId,
                        principalTable: "Appraisals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FCA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SFC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeSignoff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KeySkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerSignoff = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibilities_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complete = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager2Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    County = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DayPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmergencyContactsId = table.Column<int>(type: "int", nullable: false),
                    EveningPhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Middlename = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Town = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_EmergencyContacts_EmergencyContactsId",
                        column: x => x.EmergencyContactsId,
                        principalTable: "EmergencyContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FitnessAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<bool>(type: "bit", nullable: true),
                    FitnessId = table.Column<int>(type: "int", nullable: false),
                    FitnessQuestionId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitnessAnswers_FitnessForms_FitnessId",
                        column: x => x.FitnessId,
                        principalTable: "FitnessForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FitnessAnswers_FitnessQuestions_FitnessQuestionId",
                        column: x => x.FitnessQuestionId,
                        principalTable: "FitnessQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    TrainingType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManagerId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_FullYearReviewId",
                table: "Appraisals",
                column: "FullYearReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_MidYearReviewId",
                table: "Appraisals",
                column: "MidYearReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Breaches_StaffId",
                table: "Breaches",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_EmergencyContactsId",
                table: "Contacts",
                column: "EmergencyContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContacts_StaffId",
                table: "EmergencyContacts",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessAnswers_FitnessId",
                table: "FitnessAnswers",
                column: "FitnessId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessAnswers_FitnessQuestionId",
                table: "FitnessAnswers",
                column: "FitnessQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessForms_AssessedId",
                table: "FitnessForms",
                column: "AssessedId");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessForms_AssessorId",
                table: "FitnessForms",
                column: "AssessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Impersonations_ImpersonatesId",
                table: "Impersonations",
                column: "ImpersonatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Impersonations_ImpersonatorId",
                table: "Impersonations",
                column: "ImpersonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Objectives_AppraisalId",
                table: "Objectives",
                column: "AppraisalId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_StaffId",
                table: "Registrations",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_StaffId",
                table: "Responsibilities",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_ReviewId",
                table: "Training",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appraisals_Reviews_FullYearReviewId",
                table: "Appraisals",
                column: "FullYearReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appraisals_Reviews_MidYearReviewId",
                table: "Appraisals",
                column: "MidYearReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Primary_Manager",
                table: "Staff",
                column: "ManagerId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Secondary_Manager",
                table: "Staff",
                column: "SecondaryManagerId",
                principalTable: "Staff",
                principalColumn: "Id");
        }
    }
}
