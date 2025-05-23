using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleColumns5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MOBILE_NUMBER",
                table: "USERS",
                newName: "MOBILENUMBER");

            migrationBuilder.RenameColumn(
                name: "CREATED_AT",
                table: "USERS",
                newName: "CREATEDAT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MOBILENUMBER",
                table: "USERS",
                newName: "MOBILE_NUMBER");

            migrationBuilder.RenameColumn(
                name: "CREATEDAT",
                table: "USERS",
                newName: "CREATED_AT");
        }
    }
}
