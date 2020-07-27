using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "EmpUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LGAId",
                table: "EmpUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "LGAs",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "States",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers",
                column: "LGAId",
                principalTable: "LGAs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "LGAs",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "States",
                table: "EmpUsers");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "EmpUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LGAId",
                table: "EmpUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
