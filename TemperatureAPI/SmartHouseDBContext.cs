using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperaturesNamespace;

namespace TemperatureAPI
{
    public class SmartHouseDBContext : DbContext
    {
        public DbSet<TemperatureSensors> TemperaturesNamespace { get; set; }
        public SmartHouseDBContext(DbContextOptions<SmartHouseDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TemperatureSensors>().HasData(
                new
                {
                    TemperatureId = Guid.NewGuid(),
                    SensorTankTimeStamp = DateTime.Now,
                    SensorTankTemp = (decimal) 37.3,
                    SensorVpTurTemp = (decimal) 40.1,
                    SensorVpReturTemp = (decimal) 37.2,
                    SensorGulvReturTankTemp = (decimal) 34.3,
                    SensorGulvTurTankTemp = (decimal) 37.4,
                    IndorTemperature = (decimal) 22.5,
                    OutdorTemperature = (decimal) -3.6

                },
                new
                {
                    TemperatureId = Guid.NewGuid(),
                    SensorTankTimeStamp = DateTime.Now,
                    SensorTankTemp = (decimal) 38.1,
                    SensorVpTurTemp = (decimal) 41.2,
                    SensorVpReturTemp = (decimal) 38.3,
                    SensorGulvReturTankTemp = (decimal) 34.4,
                    SensorGulvTurTankTemp = (decimal) 38.5,
                    IndorTemperature = (decimal) 22.6,
                    OutdorTemperature = (decimal) -3.7
                }
                );
        }

    }
}
