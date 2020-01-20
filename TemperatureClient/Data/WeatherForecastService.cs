using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate, int amountDays)
        {
            var rng = new Random();

            System.Console.WriteLine("In GetForecastAsync()");

            var tmp = Task.FromResult(Enumerable.Range(1, amountDays * 24).Select(index => new WeatherForecast
            {
                Date = startDate.AddHours(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());



            return tmp;
        }

        public Task<WeatherForecast[]> GetStaticForecastAsync(DateTime startDate, int amountDays)
        {
            System.Console.WriteLine("In GetStaticForecastAsync()");

            return Task.FromResult(Enumerable.Range(1, amountDays * 24).Select(index => new WeatherForecast
            {
                Date = startDate.AddHours(index),
                TemperatureC = (int)(index * 2.3),
                Summary = Summaries[index % Summaries.Length]
            }).ToArray());
        }
    }
}