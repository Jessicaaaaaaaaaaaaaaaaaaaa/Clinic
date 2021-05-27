using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationWebAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNumber = table.Column<int>(nullable: false),
                    CourseName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Course = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.RegistrationId);
                    table.ForeignKey(
                        name: "FK_Registration_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registration_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registration_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "CourseNumber", "Description" },
                values: new object[,]
                {
                    { 1, "Critical Thinking", 1, "Learn how to analyze facts to form a judgement." },
                    { 2, "Problem Solving", 2, "Learn how to define and solve problems." },
                    { 3, "Attention to Detail", 3, "Learn how to achieve thoroughness and accuracy when accomplishing a task." }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Course", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Critical Thinking", "sholmes@gmail.com", "Sherlock", "Holmes" },
                    { 2, "Problem Solving", "jwatson@gmail.com", "John", "Watson" },
                    { 3, "Attention to Detail", "cdrew@gmail.com", "Carson", "Drew" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "ndrew@gmail.com", "Nancy", "Drew", "+4339003456" },
                    { 2, "bmarvin@yahoo.com", "Bess", "Marvin", "+2045679888" },
                    { 3, "gfayne@yahoo.com", "George", "Fayne", "+2049879000" }
                });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "StudentId", "Type" },
                values: new object[] { 1, 2, 2, 1, "Fulltime" });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "StudentId", "Type" },
                values: new object[] { 2, 2, 2, 2, "Parttime" });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "StudentId", "Type" },
                values: new object[] { 3, 1, 1, 3, "Fulltime" });

            migrationBuilder.CreateIndex(
                name: "IX_Registration_CourseId",
                table: "Registration",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_InstructorId",
                table: "Registration",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_StudentId",
                table: "Registration",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
