﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TemperatureAPI;

namespace TemperatureAPI.Migrations
{
    [DbContext(typeof(SmartHouseDBContext))]
    partial class SmartHouseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TemperaturesNamespace.TemperatureSensors", b =>
                {
                    b.Property<Guid>("TemperatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("IndorTemperature")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("OutdorTemperature")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("SensorGulvReturTankTemp")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("SensorGulvTurTankTemp")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("SensorTankTemp")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("SensorTankTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SensorVpReturTemp")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("SensorVpTurTemp")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("TemperatureId");

                    b.ToTable("TemperaturesNamespace");

                    b.HasData(
                        new
                        {
                            TemperatureId = new Guid("087ee367-8a60-4320-9c42-6e699f56c08a"),
                            IndorTemperature = 22.5m,
                            OutdorTemperature = -3.6m,
                            SensorGulvReturTankTemp = 34.3m,
                            SensorGulvTurTankTemp = 37.4m,
                            SensorTankTemp = 37.3m,
                            SensorTankTimeStamp = new DateTime(2019, 12, 17, 20, 44, 18, 660, DateTimeKind.Local).AddTicks(1643),
                            SensorVpReturTemp = 37.2m,
                            SensorVpTurTemp = 40.1m
                        },
                        new
                        {
                            TemperatureId = new Guid("37935608-27ae-4f44-86fc-45ac8fd6d5c4"),
                            IndorTemperature = 22.6m,
                            OutdorTemperature = -3.7m,
                            SensorGulvReturTankTemp = 34.4m,
                            SensorGulvTurTankTemp = 38.5m,
                            SensorTankTemp = 38.1m,
                            SensorTankTimeStamp = new DateTime(2019, 12, 17, 20, 44, 18, 662, DateTimeKind.Local).AddTicks(3544),
                            SensorVpReturTemp = 38.3m,
                            SensorVpTurTemp = 41.2m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}