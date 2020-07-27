using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class lastly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_StateId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "LGAId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "EmpUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LGAId",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_LGAId",
                table: "EmpUsers",
                column: "LGAId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_StateId",
                table: "EmpUsers",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers",
                column: "LGAId",
                principalTable: "LGAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
