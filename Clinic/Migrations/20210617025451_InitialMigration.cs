using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HealthNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntakeForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ailment = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntakeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntakeForms_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntakeForms_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gandalf" },
                    { 2, "Sauroman" },
                    { 3, "Radagast" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DateOfBirth", "HealthNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Bag-End, Underhill, Hobbiton", new DateTime(2021, 6, 16, 21, 54, 51, 387, DateTimeKind.Local).AddTicks(1452), 111222333, "Baggins", "+44 7911 123456" },
                    { 2, "3 Bagshot Row, Hobbiton", new DateTime(2021, 6, 16, 21, 54, 51, 387, DateTimeKind.Local).AddTicks(1519), 444555666, "Gamgee", "+44 7911 123457" },
                    { 3, "Brandy Hall, Buckland", new DateTime(2021, 6, 16, 21, 54, 51, 387, DateTimeKind.Local).AddTicks(1527), 777888999, "Brandybuck", "+44 7911 123458" }
                });

            migrationBuilder.InsertData(
                table: "IntakeForms",
                columns: new[] { "Id", "Ailment", "DoctorId", "PatientId" },
                values: new object[] { 1, "Extreme weight loss, irritability", 2, 1 });

            migrationBuilder.InsertData(
                table: "IntakeForms",
                columns: new[] { "Id", "Ailment", "DoctorId", "PatientId" },
                values: new object[] { 2, "Unable to enjoy gardening", 1, 2 });

            migrationBuilder.InsertData(
                table: "IntakeForms",
                columns: new[] { "Id", "Ailment", "DoctorId", "PatientId" },
                values: new object[] { 3, "Loneliness", 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_IntakeForms_DoctorId",
                table: "IntakeForms",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_IntakeForms_PatientId",
                table: "IntakeForms",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntakeForms");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
