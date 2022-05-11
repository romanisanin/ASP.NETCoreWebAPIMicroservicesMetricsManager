using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetricsAgentTests
{
    public class HddMetricsAgentTests
    {
        private HddMetricsController _hddMetricsController;

        public HddMetricsAgentTests()
        {
            _hddMetricsController = new HddMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_returnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _hddMetricsController.GetResult(fromTime, toTime);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
