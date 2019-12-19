using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureAPI.Migrations
{
    public partial class initial_migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temperatures");

            migrationBuilder.CreateTable(
                name: "TemperaturesNamespace",
                columns: table => new
                {
                    TemperatureId = table.Column<Guid>(nullable: false),
                    SensorTankTimeStamp = table.Column<DateTime>(nullable: false),
                    SensorTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorVpTurTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorVpReturTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvReturTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvTurTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IndorTemperature = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    OutdorTemperature = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperaturesNamespace", x => x.TemperatureId);
                });

            migrationBuilder.InsertData(
                table: "TemperaturesNamespace",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("087ee367-8a60-4320-9c42-6e699f56c08a"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2019, 12, 17, 20, 44, 18, 660, DateTimeKind.Local).AddTicks(1643), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "TemperaturesNamespace",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("37935608-27ae-4f44-86fc-45ac8fd6d5c4"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2019, 12, 17, 20, 44, 18, 662, DateTimeKind.Local).AddTicks(3544), 38.3m, 41.2m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemperaturesNamespace");

            migrationBuilder.CreateTable(
                name: "Temperatures",
                columns: table => new
                {
                    TemperatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndorTemperature = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    OutdorTemperature = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvReturTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvTurTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorTankTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SensorVpReturTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorVpTurTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatures", x => x.TemperatureId);
                });

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("e2b6c5f9-8d23-498a-b846-416e5fb5adb2"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2019, 12, 16, 20, 28, 6, 612, DateTimeKind.Local).AddTicks(8564), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "Temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("5e582c18-40bb-4dd3-a040-4772a6abb87b"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2019, 12, 16, 20, 28, 6, 615, DateTimeKind.Local).AddTicks(1085), 38.3m, 41.2m });
        }
    }
}
