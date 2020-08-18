using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Finalll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_AspNetUsers_AccountId1",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_AccountId1",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "AccountId1",
                table: "EmpUsers");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "EmpUsers",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "EmpUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId1",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_AccountId1",
                table: "EmpUsers",
                column: "AccountId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_AspNetUsers_AccountId1",
                table: "EmpUsers",
                column: "AccountId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
