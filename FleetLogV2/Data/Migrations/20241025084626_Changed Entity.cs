using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetLogV2.Migrations
{
    /// <inheritdoc />
    public partial class ChangedEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 1,
                column: "FileName",
                value: "/images/drivers/driver1.jpg");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 2,
                column: "FileName",
                value: "/images/drivers/driver2.jpg");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 3,
                column: "FileName",
                value: "/images/drivers/driver3.jpg");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 4,
                column: "FileName",
                value: "/images/drivers/driver4.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "FileName",
                value: "/images/managers/manager1.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "FileName",
                value: "/images/managers/manager2.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Drivers");
        }
    }
}
