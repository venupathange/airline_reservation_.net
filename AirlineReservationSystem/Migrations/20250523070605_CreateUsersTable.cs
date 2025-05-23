using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "USERS");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "USERS",
                type: "NVARCHAR2(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USERS",
                table: "USERS",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_USERS",
                table: "USERS");

            migrationBuilder.RenameTable(
                name: "USERS",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
