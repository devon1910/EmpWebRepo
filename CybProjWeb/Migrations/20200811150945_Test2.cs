using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_EmpUsers_UserId",
                table: "Salaries");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Salaries",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_EmpUsers_UserId",
                table: "Salaries",
                column: "UserId",
                principalTable: "EmpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_EmpUsers_UserId",
                table: "Salaries");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Salaries",
                nullable: true,
                oldClrType: typeof(int));

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
