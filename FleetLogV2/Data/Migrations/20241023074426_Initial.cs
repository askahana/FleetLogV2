using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetLogV2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarReg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Drivers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventType = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "EmployeeName" },
                values: new object[,]
                {
                    { 1, "feli@mail.se", "Felicia Jahansson" },
                    { 2, "jack@mail.se", "Jack Black" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "CarReg", "DriverName", "EmployeeId" },
                values: new object[,]
                {
                    { 1, "ABC123", "Bengt Andersson", 1 },
                    { 2, "CDE234", "Sven Eriksson", 1 },
                    { 3, "CAL234", "Karin Larsson", 2 },
                    { 4, "MUM234", "Tove Jansson", 2 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "AmountIn", "AmountOut", "DriverId", "EventType", "TimeStamp" },
                values: new object[,]
                {
                    { 1, 0m, 0m, 1, 0, new DateTime(2024, 9, 10, 10, 30, 50, 0, DateTimeKind.Unspecified) },
                    { 2, 400m, 0m, 1, 1, new DateTime(2024, 9, 10, 15, 30, 50, 0, DateTimeKind.Unspecified) },
                    { 3, 0m, 0m, 2, 0, new DateTime(2024, 9, 10, 5, 30, 50, 0, DateTimeKind.Unspecified) },
                    { 4, 1000m, 0m, 2, 1, new DateTime(2024, 9, 10, 5, 30, 50, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_EmployeeId",
                table: "Drivers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_DriverId",
                table: "Events",
                column: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
