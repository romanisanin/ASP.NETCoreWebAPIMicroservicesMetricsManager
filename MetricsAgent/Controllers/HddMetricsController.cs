using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        // d. api / metrics / hdd / left / from /{ fromTime}/ to /{ toTime}
        [HttpGet("/left/from/{fromTime]/to/{toTime}")]
        public IActionResult GetResult(
            [FromRoute] TimeSpan fromTime, TimeSpan toTime)
        {
            return Ok();
        }
    }
}
