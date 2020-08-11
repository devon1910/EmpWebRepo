using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_EmpUsers_UserId1",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_UserId1",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Salaries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Salaries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Salaries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_UserId1",
                table: "Salaries",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_EmpUsers_UserId1",
                table: "Salaries",
                column: "UserId1",
                principalTable: "EmpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
