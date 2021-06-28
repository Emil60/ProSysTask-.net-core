using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prosystask1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    code = table.Column<string>(type: "char(3)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: true),
                    Form = table.Column<decimal>(type: "decimal(2,0)", nullable: false),
                    TeacherName = table.Column<string>(type: "varchar(20)", nullable: true),
                    TeacherSurname = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<decimal>(type: "decimal(5,0)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(30)", nullable: true),
                    Form = table.Column<decimal>(type: "decimal(2,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Courseid = table.Column<string>(nullable: false),
                    Studentid = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(1,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_Course_Courseid",
                        column: x => x.Courseid,
                        principalTable: "Course",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Student_Studentid",
                        column: x => x.Studentid,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Courseid",
                table: "Exam",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Studentid",
                table: "Exam",
                column: "Studentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
