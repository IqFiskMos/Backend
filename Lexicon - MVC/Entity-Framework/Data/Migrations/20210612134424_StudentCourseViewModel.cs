using Microsoft.EntityFrameworkCore.Migrations;

namespace EFW_Assignment.Data.Migrations
{
    public partial class StudentCourseViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentCourses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentCourseViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    teacherId = table.Column<int>(nullable: false),
                    AssignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModels_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModels_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModels_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseViewModels_Teachers_teacherId",
                        column: x => x.teacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModels_AssignmentId",
                table: "StudentCourseViewModels",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModels_CourseId",
                table: "StudentCourseViewModels",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModels_StudentId",
                table: "StudentCourseViewModels",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseViewModels_teacherId",
                table: "StudentCourseViewModels",
                column: "teacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourseViewModels");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");
        }
    }
}
