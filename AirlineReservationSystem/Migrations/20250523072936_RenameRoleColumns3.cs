using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleColumns3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "USERS");

            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "USERS",
                newName: "\"ROLE\"");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "USERS",
                newName: "\"PASSWORD\"");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "USERS",
                newName: "\"MOBILE_NUMBER\"");

            migrationBuilder.AlterColumn<string>(
                name: "\"MOBILE_NUMBER\"",
                table: "USERS",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(10)",
                oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "\"ROLE\"",
                table: "USERS",
                newName: "ROLE");

            migrationBuilder.RenameColumn(
                name: "\"PASSWORD\"",
                table: "USERS",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "\"MOBILE_NUMBER\"",
                table: "USERS",
                newName: "MobileNumber");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "USERS",
                type: "NVARCHAR2(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "USERS",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
