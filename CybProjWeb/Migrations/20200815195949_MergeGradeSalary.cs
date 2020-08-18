using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CybProjWeb.Migrations
{
    public partial class MergeGradeSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_Faculties_FacultyId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_FacultyId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "EmpUsers");

            migrationBuilder.RenameColumn(
                name: "Step",
                table: "Grade",
                newName: "TransportItemType");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Grade",
                newName: "MedicalItemType");

            migrationBuilder.AddColumn<double>(
                name: "BasicSalary",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Grade",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradeLevel",
                table: "Grade",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradeStep",
                table: "Grade",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "GrossSalary",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Housing",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "HousingItemType",
                table: "Grade",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HousingPercent",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Lunch",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LunchItemType",
                table: "Grade",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LunchPercent",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Medical",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MedicalPercent",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NetSalary",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TaxPercent",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Transport",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TransportPercent",
                table: "Grade",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "FacultyCode",
                table: "Faculties",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AddColumn<double>(
                name: "BasicSalary",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradeLevel",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GradeName",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradeStep",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "GrossSalary",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Housing",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "HousingItemType",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Lunch",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LunchItemType",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Medical",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MedicalItemType",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NetSalary",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Transport",
                table: "EmpUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TransportItemType",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeptCode",
                table: "Departments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_GradeId",
                table: "EmpUsers",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_Grade_GradeId",
                table: "EmpUsers",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_Grade_GradeId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_LGAs_LGAId",
                table: "EmpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpUsers_States_StateId",
                table: "EmpUsers");

            migrationBuilder.DropIndex(
                name: "IX_EmpUsers_GradeId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "BasicSalary",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "GradeLevel",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "GradeStep",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "GrossSalary",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Housing",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "HousingItemType",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "HousingPercent",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Lunch",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "LunchItemType",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "LunchPercent",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Medical",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "MedicalPercent",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "TaxPercent",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Transport",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "TransportPercent",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "BasicSalary",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "GradeLevel",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "GradeName",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "GradeStep",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "GrossSalary",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "Housing",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "HousingItemType",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "Lunch",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "LunchItemType",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "Medical",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "MedicalItemType",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "Transport",
                table: "EmpUsers");

            migrationBuilder.DropColumn(
                name: "TransportItemType",
                table: "EmpUsers");

            migrationBuilder.RenameColumn(
                name: "TransportItemType",
                table: "Grade",
                newName: "Step");

            migrationBuilder.RenameColumn(
                name: "MedicalItemType",
                table: "Grade",
                newName: "Level");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyCode",
                table: "Faculties",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "EmpUsers",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeptCode",
                table: "Departments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasicSalary = table.Column<double>(nullable: false),
                    GradeId = table.Column<int>(nullable: false),
                    GradeLevel = table.Column<string>(nullable: true),
                    GradeName = table.Column<string>(nullable: true),
                    GradeStep = table.Column<string>(nullable: true),
                    GrossSalary = table.Column<double>(nullable: false),
                    Housing = table.Column<double>(nullable: false),
                    HousingItemType = table.Column<string>(nullable: true),
                    HousingPercent = table.Column<double>(nullable: false),
                    Lunch = table.Column<double>(nullable: false),
                    LunchItemType = table.Column<string>(nullable: true),
                    LunchPercent = table.Column<double>(nullable: false),
                    Medical = table.Column<double>(nullable: false),
                    MedicalItemType = table.Column<string>(nullable: true),
                    MedicalPercent = table.Column<double>(nullable: false),
                    NetSalary = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    TaxPercent = table.Column<double>(nullable: false),
                    Transport = table.Column<double>(nullable: false),
                    TransportItemType = table.Column<string>(nullable: true),
                    TransportPercent = table.Column<double>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salaries_EmpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "EmpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpUsers_FacultyId",
                table: "EmpUsers",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_GradeId",
                table: "Salaries",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_UserId",
                table: "Salaries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpUsers_Faculties_FacultyId",
                table: "EmpUsers",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}
