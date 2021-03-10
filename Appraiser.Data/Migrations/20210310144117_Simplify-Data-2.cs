using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class SimplifyData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropIndex(
                name: "IX_Appraisals_StaffId_PeriodStart_Deleted",
                table: "Appraisals");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_StaffId",
                table: "Appraisals",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appraisals_StaffId",
                table: "Appraisals");

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KeyId = table.Column<int>(type: "int", nullable: false),
                    New = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Old = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    Table = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Changes_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManagerId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_StaffId_PeriodStart_Deleted",
                table: "Appraisals",
                columns: new[] { "StaffId", "PeriodStart", "Deleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Changes_StaffId",
                table: "Changes",
                column: "StaffId");
        }
    }
}
