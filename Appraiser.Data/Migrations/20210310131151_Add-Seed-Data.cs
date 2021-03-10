using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "IsFitAndProper", "IsSuperUser", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 1, "mgr1@company.com", false, false, "mgr1", null, "Manager 1", null });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "IsFitAndProper", "IsSuperUser", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 2, "mgr2@company.com", false, false, "mgr2", 1, "Manager 2", null });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "IsFitAndProper", "IsSuperUser", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 3, "emp@company.com", false, false, "emp", 1, "Employee", 2 });

            migrationBuilder.InsertData(
                table: "Appraisals",
                columns: new[] { "Id", "Complete", "Deleted", "FullYearReviewId", "MidYearReviewId", "ObjectivesLocked", "PeriodEnd", "PeriodStart", "StaffId" },
                values: new object[] { 1, false, false, null, null, false, new DateTimeOffset(new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appraisals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
