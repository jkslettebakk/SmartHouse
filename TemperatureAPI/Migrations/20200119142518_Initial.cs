using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemperaturesNamespace",
                columns: table => new
                {
                    TemperatureId = table.Column<Guid>(nullable: false),
                    SensorTankTimeStamp = table.Column<DateTime>(nullable: false),
                    SensorTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorVpTurTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorVpReturTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvTurTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SensorGulvReturTankTemp = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IndorTemperature = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    OutdorTemperature = table.Column<decimal>(type: "decimal(4,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperaturesNamespace", x => x.TemperatureId);
                });

            migrationBuilder.InsertData(
                table: "TemperaturesNamespace",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("707bb273-be8c-4d87-81db-5947cb6d2215"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2020, 1, 19, 15, 25, 18, 553, DateTimeKind.Local).AddTicks(9364), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "TemperaturesNamespace",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("24f1d0be-c252-44d8-b2a0-40761071d0c3"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2020, 1, 19, 15, 25, 18, 556, DateTimeKind.Local).AddTicks(691), 38.3m, 41.2m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemperaturesNamespace");
        }
    }
}
