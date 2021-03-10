using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class AddStaffIdToChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Changes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Changes_StaffId",
                table: "Changes",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Changes_Staff_StaffId",
                table: "Changes",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Changes_Staff_StaffId",
                table: "Changes");

            migrationBuilder.DropIndex(
                name: "IX_Changes_StaffId",
                table: "Changes");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Changes");
        }
    }
}
