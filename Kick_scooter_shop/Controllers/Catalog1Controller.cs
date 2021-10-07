using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Kick_scooter_shop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Catalog1Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<Catalog1Controller> _logger;

        public Catalog1Controller(ILogger<Catalog1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Catalog1> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Catalog1
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}