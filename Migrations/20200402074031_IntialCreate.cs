using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentCore.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "varchar(250)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Modified_By = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Code = table.Column<string>(type: "varchar(250)", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    Branch = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<string>(type: "varchar(250)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Statuts = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Modified_By = table.Column<int>(type: "int", nullable: false),
                    Modified_Date = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
