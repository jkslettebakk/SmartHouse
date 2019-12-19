using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureAPI.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "temperatures",
                columns: table => new
                {
                    TemperatureId = table.Column<Guid>(nullable: false),
                    SensorTankTimeStamp = table.Column<DateTime>(nullable: false),
                    SensorTankTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    SensorVpTurTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    SensorVpReturTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    SensorGulvReturTankTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    SensorGulvTurTankTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    IndorTemperature = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    OutdorTemperature = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temperatures", x => x.TemperatureId);
                });

            migrationBuilder.InsertData(
                table: "temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("eb72a0ae-2f25-4806-841e-4425c8c30efd"), 22.5m, -3.6m, 34.3m, 37.4m, 37.3m, new DateTime(2019, 12, 16, 19, 34, 19, 589, DateTimeKind.Local).AddTicks(7258), 37.2m, 40.1m });

            migrationBuilder.InsertData(
                table: "temperatures",
                columns: new[] { "TemperatureId", "IndorTemperature", "OutdorTemperature", "SensorGulvReturTankTemp", "SensorGulvTurTankTemp", "SensorTankTemp", "SensorTankTimeStamp", "SensorVpReturTemp", "SensorVpTurTemp" },
                values: new object[] { new Guid("d71a95ed-6683-48a0-b241-d29803210fe2"), 22.6m, -3.7m, 34.4m, 38.5m, 38.1m, new DateTime(2019, 12, 16, 19, 34, 19, 592, DateTimeKind.Local).AddTicks(816), 38.3m, 41.2m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "temperatures");
        }
    }
}
