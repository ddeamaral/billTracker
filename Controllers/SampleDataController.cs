using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using marriednowwhat.Models;
using Microsoft.AspNetCore.Mvc;

namespace marriednowwhat.Controllers
{
    [Route ("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new []
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        private static string[] Bills = new []
        {
            "Car",
            "Rent",
            "Electricity",
            "Gas",
            "Water",
            "Credit Card",
        };

        [HttpGet ("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts ()
        {
            var rng = new Random ();
            return Enumerable.Range (1, 5).Select (index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays (index).ToString ("d"),
                    TemperatureC = rng.Next (-20, 55),
                    Summary = Summaries[rng.Next (Summaries.Length)]
            });
        }

        [HttpGet ("[action]")]
        public IEnumerable<Bill> GetBills ()
        {

            var bills = Enumerable.Range (0, Bills.Length).Select (index => new Bill () { Name = Bills[index] });

            return bills;
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int) (TemperatureC / 0.5556);
                }
            }
        }
    }
}