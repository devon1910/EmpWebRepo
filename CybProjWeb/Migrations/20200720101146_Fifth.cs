using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LGAs_States_StatesStateId",
                table: "LGAs");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "States",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StatesStateId",
                table: "LGAs",
                newName: "StatesId");

            migrationBuilder.RenameColumn(
                name: "LGAId",
                table: "LGAs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_LGAs_StatesStateId",
                table: "LGAs",
                newName: "IX_LGAs_StatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_LGAs_States_StatesId",
                table: "LGAs",
                column: "StatesId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LGAs_States_StatesId",
                table: "LGAs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "States",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "StatesId",
                table: "LGAs",
                newName: "StatesStateId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LGAs",
                newName: "LGAId");

            migrationBuilder.RenameIndex(
                name: "IX_LGAs_StatesId",
                table: "LGAs",
                newName: "IX_LGAs_StatesStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_LGAs_States_StatesStateId",
                table: "LGAs",
                column: "StatesStateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
