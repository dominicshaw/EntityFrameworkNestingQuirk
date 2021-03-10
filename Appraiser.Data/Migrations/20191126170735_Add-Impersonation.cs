using Microsoft.EntityFrameworkCore.Migrations;

namespace Appraiser.Data.Migrations
{
    public partial class AddImpersonation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impersonations",
                columns: table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpersonatorId = table.Column<int>(),
                    ImpersonatesId = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impersonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Impersonations_Staff_ImpersonatesId",
                        column: x => x.ImpersonatesId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impersonation_Staff_Id",
                        column: x => x.ImpersonatorId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Impersonations_ImpersonatesId",
                table: "Impersonations",
                column: "ImpersonatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Impersonations_ImpersonatorId",
                table: "Impersonations",
                column: "ImpersonatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impersonations");
        }
    }
}
