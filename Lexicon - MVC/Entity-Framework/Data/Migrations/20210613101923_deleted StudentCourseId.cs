using Microsoft.EntityFrameworkCore.Migrations;

namespace EFW_Assignment.Data.Migrations
{
    public partial class deletedStudentCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
