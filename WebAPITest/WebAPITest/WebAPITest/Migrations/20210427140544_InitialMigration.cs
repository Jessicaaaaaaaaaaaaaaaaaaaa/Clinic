using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPITest.Migrations
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructoreID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true),
                    IntructorId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "InstructoreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registration_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Credits", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Accounting" },
                    { 2, 3, "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructoreID", "Name" },
                values: new object[,]
                {
                    { 1, "Daisy Duck" },
                    { 2, "Tom" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Name" },
                values: new object[,]
                {
                    { 1, "John Smith" },
                    { 2, "Liza Ray" }
                });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "IntructorId", "StudentId", "Type" },
                values: new object[] { 1, 1, null, 1, 1, "Fulltime" });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "IntructorId", "StudentId", "Type" },
                values: new object[] { 2, 1, null, 1, 2, "Parttime" });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "RegistrationId", "CourseId", "InstructorId", "IntructorId", "StudentId", "Type" },
                values: new object[] { 3, 2, null, 2, 2, "Fulltime" });

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
