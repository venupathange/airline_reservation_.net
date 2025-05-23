using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleColumns4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "USERS",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "USERS",
                newName: "GENDER");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "USERS",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "USERS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "\"ROLE\"",
                table: "USERS",
                newName: "ROLE");

            migrationBuilder.RenameColumn(
                name: "\"PASSWORD\"",
                table: "USERS",
                newName: "PASSWORD");

            migrationBuilder.RenameColumn(
                name: "\"MOBILE_NUMBER\"",
                table: "USERS",
                newName: "MOBILE_NUMBER");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATED_AT",
                table: "USERS",
                type: "TIMESTAMP(7)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CREATED_AT",
                table: "USERS");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "USERS",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GENDER",
                table: "USERS",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "USERS",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "USERS",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "USERS",
                newName: "\"ROLE\"");

            migrationBuilder.RenameColumn(
                name: "PASSWORD",
                table: "USERS",
                newName: "\"PASSWORD\"");

            migrationBuilder.RenameColumn(
                name: "MOBILE_NUMBER",
                table: "USERS",
                newName: "\"MOBILE_NUMBER\"");
        }
    }
}
