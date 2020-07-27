using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_FacultyId",
                table: "EmpUsers",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_Faculties_FacultyId",
                table: "EmpUsers",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_Faculties_FacultyId",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_FacultyId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "EmpUsers");
        }
    }
}
