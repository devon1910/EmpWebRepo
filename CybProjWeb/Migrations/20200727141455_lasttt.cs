using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class lasttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_Country_CountryId",
                table: "EmpUsers");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_CountryId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "EmpUsers");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "EmpUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "EmpUsers");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_CountryId",
                table: "EmpUsers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_Country_CountryId",
                table: "EmpUsers",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
