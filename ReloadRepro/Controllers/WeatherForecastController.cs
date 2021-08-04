using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ReloadRepro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "hello world" };
        }
    }
}
