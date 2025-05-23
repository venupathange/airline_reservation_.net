using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USER_ROLE",
                table: "USERS",
                newName: "ROLE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "USERS",
                newName: "USER_ROLE");
        }
    }
}
