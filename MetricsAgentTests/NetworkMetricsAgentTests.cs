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
    public class NetworkMetricsAgentTests
    {
        private NetworkMetricsController _networkMetricsController;
        
        public NetworkMetricsAgentTests()
        {
            _networkMetricsController = new NetworkMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnOK()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _networkMetricsController.GetMetrics(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
