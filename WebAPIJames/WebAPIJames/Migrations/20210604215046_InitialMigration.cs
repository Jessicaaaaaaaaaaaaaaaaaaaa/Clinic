using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIJames.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationMenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationMenuItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationMenuItems_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Name", "Price", "ReservationId" },
                values: new object[,]
                {
                    { 1, "Kjielkje & Schmaunt Fat", 14.99, null },
                    { 2, "Plumi Moos", 7.9900000000000002, null },
                    { 3, "Vereniki", 12.99, null }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 4, 16, 50, 45, 972, DateTimeKind.Local).AddTicks(1305), "John Klassen" },
                    { 2, new DateTime(2021, 6, 4, 16, 50, 45, 975, DateTimeKind.Local).AddTicks(9863), "Margaret Froese" },
                    { 3, new DateTime(2021, 6, 4, 16, 50, 45, 975, DateTimeKind.Local).AddTicks(9905), "Anna Giesbrecht" }
                });

            migrationBuilder.InsertData(
                table: "ReservationMenuItems",
                columns: new[] { "Id", "MenuItemId", "ReservationId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ReservationMenuItems",
                columns: new[] { "Id", "MenuItemId", "ReservationId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "ReservationMenuItems",
                columns: new[] { "Id", "MenuItemId", "ReservationId" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_ReservationId",
                table: "MenuItems",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationMenuItems_MenuItemId",
                table: "ReservationMenuItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationMenuItems_ReservationId",
                table: "ReservationMenuItems",
                column: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationMenuItems");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
