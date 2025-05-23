using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "FLIGHTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FlightName = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    AirplaneId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SourceAirportId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DestinationAirportId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FLIGHTS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Role = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Gender = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    MobileNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FLIGHTS");

            migrationBuilder.DropTable(
                name: "Users");

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
    }
}
