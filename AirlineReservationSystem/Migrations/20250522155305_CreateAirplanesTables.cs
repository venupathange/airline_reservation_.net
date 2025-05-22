using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateAirplanesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Airplanes",
                table: "Airplanes");

            migrationBuilder.RenameTable(
                name: "Airplanes",
                newName: "AIRPLANES");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AIRPLANES",
                table: "AIRPLANES",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AIRPLANES",
                table: "AIRPLANES");

            migrationBuilder.RenameTable(
                name: "AIRPLANES",
                newName: "Airplanes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airplanes",
                table: "Airplanes",
                column: "Id");
        }
    }
}
