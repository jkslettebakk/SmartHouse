using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureAPI.Migrations
{
    public partial class initial_migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_temperatures",
                table: "temperatures");

            migrationBuilder.DeleteData(
                table: "temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("d71a95ed-6683-48a0-b241-d29803210fe2"));

            migrationBuilder.DeleteData(
                table: "temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("eb72a0ae-2f25-4806-841e-4425c8c30efd"));

            migrationBuilder.RenameTable(
                name: "temperatures",
                newName: "Temperatures");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorVpTurTemp",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorVpReturTemp",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorTankTemp",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorGulvTurTankTemp",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorGulvReturTankTemp",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutdorTemperature",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IndorTemperature",
                table: "Temperatures",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Temperatures",
                table: "Temperatures",
                column: "TemperatureId");

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("e2b6c5f9-8d23-498a-b846-416e5fb5adb2"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2019, 12, 16, 20, 28, 6, 612, DateTimeKind.Local).AddTicks(8564), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("5e582c18-40bb-4dd3-a040-4772a6abb87b"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2019, 12, 16, 20, 28, 6, 615, DateTimeKind.Local).AddTicks(1085), 38.3m, 41.2m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Temperatures",
                table: "Temperatures");

            migrationBuilder.DeleteData(
                table: "Temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("5e582c18-40bb-4dd3-a040-4772a6abb87b"));

            migrationBuilder.DeleteData(
                table: "Temperatures",
                keyColumn: "TemperatureId",
                keyValue: new Guid("e2b6c5f9-8d23-498a-b846-416e5fb5adb2"));

            migrationBuilder.RenameTable(
                name: "Temperatures",
                newName: "temperatures");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorVpTurTemp",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorVpReturTemp",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorTankTemp",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorGulvTurTankTemp",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SensorGulvReturTankTemp",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutdorTemperature",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IndorTemperature",
                table: "temperatures",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_temperatures",
                table: "temperatures",
                column: "TemperatureId");

            migrationBuilder.InsertData(
                table: "temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("eb72a0ae-2f25-4806-841e-4425c8c30efd"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2019, 12, 16, 19, 34, 19, 589, DateTimeKind.Local).AddTicks(7258), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("d71a95ed-6683-48a0-b241-d29803210fe2"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2019, 12, 16, 19, 34, 19, 592, DateTimeKind.Local).AddTicks(816), 38.3m, 41.2m });
        }
    }
}
