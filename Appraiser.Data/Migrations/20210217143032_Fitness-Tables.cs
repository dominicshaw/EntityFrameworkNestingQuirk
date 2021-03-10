using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class FitnessTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFitAndProper",
                table: "Staff",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "FitnessForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(maxLength: 100, nullable: true),
                    AssessmentType = table.Column<string>(maxLength: 100, nullable: true),
                    AssessedId = table.Column<int>(nullable: true),
                    AssessorId = table.Column<int>(nullable: true),
                    AssessorRole = table.Column<string>(maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    NextAssessmentDate = table.Column<DateTime>(nullable: true),
                    HonestyAssessed = table.Column<string>(maxLength: 200, nullable: true),
                    CompetenceAssessed = table.Column<string>(maxLength: 200, nullable: true),
                    FinancesAssessed = table.Column<string>(maxLength: 200, nullable: true),
                    SupportingEvidence = table.Column<bool>(nullable: true),
                    PassCriteria = table.Column<bool>(nullable: true),
                    ImposedLimitations = table.Column<bool>(nullable: true),
                    CertificateProvided = table.Column<bool>(nullable: true),
                    ComplianceSignoffAt = table.Column<DateTime>(nullable: true),
                    ComplianceSignoffBy = table.Column<string>(maxLength: 100, nullable: true),
                    ComplianceSignoffNotes = table.Column<string>(maxLength: 500, nullable: true),
                    HrSignoffAt = table.Column<DateTime>(nullable: true),
                    HrSignoffBy = table.Column<string>(maxLength: 100, nullable: true),
                    HrSignoffNotes = table.Column<string>(maxLength: 500, nullable: true),
                    ManagerSignoffAt = table.Column<DateTime>(nullable: true),
                    ManagerSignoffBy = table.Column<string>(maxLength: 100, nullable: true),
                    ManagerSignoffNotes = table.Column<string>(maxLength: 500, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionNumber = table.Column<int>(nullable: false),
                    Section = table.Column<string>(maxLength: 100, nullable: true),
                    Subsection = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FitnessId = table.Column<int>(nullable: false),
                    FitnessQuestionId = table.Column<int>(nullable: false),
                    Answer = table.Column<bool>(nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FitnessAnswers");

            migrationBuilder.DropTable(
                name: "FitnessForms");

            migrationBuilder.DropTable(
                name: "FitnessQuestions");

            migrationBuilder.DropColumn(
                name: "IsFitAndProper",
                table: "Staff");
        }
    }
}
