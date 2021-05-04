using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegWebAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNumber = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.RegistrationId);
                    table.ForeignKey(
                        name: "FK_Registrations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Students_StudentId",
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
                    { 1, "Accounting", 101, "Learn to account for your actions." },
                    { 2, "Finance", 202, "Finance your dream getaway with us!" },
                    { 3, "Rainbows", 303, "Find the pot of gold in your life today!" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "Course", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Accounting", "dduck@gmail.com", "Daisy", "Duck" },
                    { 2, "Finance", "tbargen@gmail.com", "Tom", "Bargen" },
                    { 3, "Rainbows", "sobama@gmail.com", "Sasha", "Obama" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "jsmith@gmail.com", "John", "Smith", "(204) 123-4567" },
                    { 2, "lray@gmail.com", "Liza", "Ray", "(204) 123-4568" },
                    { 3, "mfraise@gmail.com", "Michelle", "Fraise", "(204) 123-4569" }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "RegistrationType", "StudentId" },
                values: new object[] { 1, 1, 1, "Fulltime", 1 });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "RegistrationType", "StudentId" },
                values: new object[] { 2, 1, 1, "Parttime", 2 });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "RegistrationType", "StudentId" },
                values: new object[] { 3, 2, 2, "Fulltime", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CourseId",
                table: "Registrations",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_InstructorId",
                table: "Registrations",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_StudentId",
                table: "Registrations",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
