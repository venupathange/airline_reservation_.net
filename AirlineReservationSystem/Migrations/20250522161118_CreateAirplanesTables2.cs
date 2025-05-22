using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateAirplanesTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalSeats",
                table: "AIRPLANES",
                newName: "TOTALSEATS");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "AIRPLANES",
                newName: "MODEL");

            migrationBuilder.RenameColumn(
                name: "EconomySeats",
                table: "AIRPLANES",
                newName: "ECONOMYSEATS");

            migrationBuilder.RenameColumn(
                name: "BusinessSeats",
                table: "AIRPLANES",
                newName: "BUSINESSSEATS");

            migrationBuilder.RenameColumn(
                name: "AirplaneNumber",
                table: "AIRPLANES",
                newName: "AIRPLANENUMBER");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AIRPLANES",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TOTALSEATS",
                table: "AIRPLANES",
                newName: "TotalSeats");

            migrationBuilder.RenameColumn(
                name: "MODEL",
                table: "AIRPLANES",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ECONOMYSEATS",
                table: "AIRPLANES",
                newName: "EconomySeats");

            migrationBuilder.RenameColumn(
                name: "BUSINESSSEATS",
                table: "AIRPLANES",
                newName: "BusinessSeats");

            migrationBuilder.RenameColumn(
                name: "AIRPLANENUMBER",
                table: "AIRPLANES",
                newName: "AirplaneNumber");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AIRPLANES",
                newName: "Id");
        }
    }
}
