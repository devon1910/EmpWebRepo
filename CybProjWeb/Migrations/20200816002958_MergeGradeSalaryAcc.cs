using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class MergeGradeSalaryAcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_AccountId",
                table: "EmpUsers",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_AspNetUsers_AccountId",
                table: "EmpUsers",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_AspNetUsers_AccountId",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_AccountId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "EmpUsers");
        }
    }
}
