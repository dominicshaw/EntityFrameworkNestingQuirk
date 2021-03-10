using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class SecondaryManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Staff_ManagerId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "SecondaryManagerId",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manager2Notes",
                table: "Reviews",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SecondaryManagerId",
                table: "Staff",
                column: "SecondaryManagerId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Primary_Manager",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Secondary_Manager",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_SecondaryManagerId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "SecondaryManagerId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Manager2Notes",
                table: "Reviews");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Staff_ManagerId",
                table: "Staff",
                column: "ManagerId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
