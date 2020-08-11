using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class lazyyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LGAs",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "States",
                table: "EmpUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LGAs",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "States",
                table: "EmpUsers",
                nullable: true);
        }
    }
}
