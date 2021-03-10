using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    SecondaryManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Staff_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Staff_SecondaryManagerId",
                        column: x => x.SecondaryManagerId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appraisals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PeriodStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PeriodEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Complete = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraisals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appraisals_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 1, "mgr1@company.com", "mgr1", null, "Manager 1", null });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 2, "mgr2@company.com", "mgr2", 1, "Manager 2", null });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "Logon", "ManagerId", "Name", "SecondaryManagerId" },
                values: new object[] { 3, "emp@company.com", "emp", 1, "Employee", 2 });

            migrationBuilder.InsertData(
                table: "Appraisals",
                columns: new[] { "Id", "Complete", "Deleted", "PeriodEnd", "PeriodStart", "StaffId" },
                values: new object[] { 1, false, false, new DateTimeOffset(new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3 });
            
            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_StaffId",
                table: "Appraisals",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ManagerId",
                table: "Staff",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SecondaryManagerId",
                table: "Staff",
                column: "SecondaryManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appraisals");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
