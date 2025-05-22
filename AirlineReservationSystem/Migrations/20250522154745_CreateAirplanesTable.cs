using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateAirplanesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_airplanes",
                table: "airplanes");

            migrationBuilder.DropColumn(
                name: "Airline",
                table: "airplanes");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "airplanes");

            migrationBuilder.DropColumn(
                name: "Manufacture",
                table: "airplanes");

            migrationBuilder.RenameTable(
                name: "airplanes",
                newName: "Airplanes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Airports",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Airports",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Airports",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Airports",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Airplanes",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Airplanes",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddColumn<string>(
                name: "AirplaneNumber",
                table: "Airplanes",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BusinessSeats",
                table: "Airplanes",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EconomySeats",
                table: "Airplanes",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalSeats",
                table: "Airplanes",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airplanes",
                table: "Airplanes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Airplanes",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "AirplaneNumber",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "BusinessSeats",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "EconomySeats",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "TotalSeats",
                table: "Airplanes");

            migrationBuilder.RenameTable(
                name: "Airplanes",
                newName: "airplanes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Airports",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "airplanes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "airplanes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddColumn<string>(
                name: "Airline",
                table: "airplanes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "airplanes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Manufacture",
                table: "airplanes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_airplanes",
                table: "airplanes",
                column: "Id");
        }
    }
}
