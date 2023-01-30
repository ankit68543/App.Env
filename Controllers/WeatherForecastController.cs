using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Env.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IConfiguration Configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var value = Configuration.GetValue<string>("app:env");
            return value;
        }
    }
}
