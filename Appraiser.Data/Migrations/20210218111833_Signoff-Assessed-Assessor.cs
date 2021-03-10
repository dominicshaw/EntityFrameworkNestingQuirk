using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class SignoffAssessedAssessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerSignoffAt",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "ManagerSignoffBy",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "ManagerSignoffNotes",
                table: "FitnessForms");

            migrationBuilder.AddColumn<DateTime>(
                name: "AssessedSignoffAt",
                table: "FitnessForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessedSignoffBy",
                table: "FitnessForms",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessedSignoffNotes",
                table: "FitnessForms",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssessorSignoffAt",
                table: "FitnessForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessorSignoffBy",
                table: "FitnessForms",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessorSignoffNotes",
                table: "FitnessForms",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssessedSignoffAt",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "AssessedSignoffBy",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "AssessedSignoffNotes",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "AssessorSignoffAt",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "AssessorSignoffBy",
                table: "FitnessForms");

            migrationBuilder.DropColumn(
                name: "AssessorSignoffNotes",
                table: "FitnessForms");

            migrationBuilder.AddColumn<DateTime>(
                name: "ManagerSignoffAt",
                table: "FitnessForms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignoffBy",
                table: "FitnessForms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagerSignoffNotes",
                table: "FitnessForms",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }
    }
}
