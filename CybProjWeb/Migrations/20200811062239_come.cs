using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class come : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_EmpUsers_UserId",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_UserId",
                table: "Salaries");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Salaries",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_EmpUsers_UserId1",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_UserId1",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Salaries");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Salaries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_UserId",
                table: "Salaries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_EmpUsers_UserId",
                table: "Salaries",
                column: "UserId",
                principalTable: "EmpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
