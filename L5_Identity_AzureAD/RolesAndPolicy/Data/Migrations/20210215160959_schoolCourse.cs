using Microsoft.EntityFrameworkCore.Migrations;

namespace RolesAndPolicy.Data.Migrations
{
    public partial class schoolCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolCourses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClassSchoolCourse",
                columns: table => new
                {
                    CoursesId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    SchoolClassesId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClassSchoolCourse", x => new { x.CoursesId, x.SchoolClassesId });
                    table.ForeignKey(
                        name: "FK_SchoolClassSchoolCourse_SchoolClasses_SchoolClassesId",
                        column: x => x.SchoolClassesId,
                        principalTable: "SchoolClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClassSchoolCourse_SchoolCourses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "SchoolCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassSchoolCourse_SchoolClassesId",
                table: "SchoolClassSchoolCourse",
                column: "SchoolClassesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolClassSchoolCourse");

            migrationBuilder.DropTable(
                name: "SchoolCourses");
        }
    }
}
