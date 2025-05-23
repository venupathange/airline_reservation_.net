using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleColumnnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "USERS",
                newName: "USER_ROLE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USER_ROLE",
                table: "USERS",
                newName: "Role");
        }
    }
}
