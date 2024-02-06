using Microsoft.AspNetCore.Mvc;

namespace AwsApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        //private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            //_logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var t = "";
            if (t == "1")
            {
                if (t == "2")
                {
                    if (t == "3")
                    {
                        if (t == "4")
                        {
                            if (t == "5")
                            {
                                if (t == "6")
                                {
                                    Console.WriteLine("123");
                                }
                            }
                            else
                            {
                                Console.WriteLine("12345");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("1234");
                    }
                }

            }
            else if (t == "2")
            {
                Console.WriteLine("123");
            }
            else if (t == "3")
            {
                Console.WriteLine("123");
            }
            else if (t == "4")
            {
                Console.WriteLine("123");
            }
            else if (t == "5")
            {
                Console.WriteLine("123");
            }
            else if (t == "6")
            {
                Console.WriteLine("123");
            }
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}