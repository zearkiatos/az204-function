using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace az204_function
{
    public class az204_prog_timer_fuction
    {
        private readonly ILogger _logger;

        public az204_prog_timer_fuction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<az204_prog_timer_fuction>();
        }

        [Function("az204_prog_timer_fuction")]
        public void Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
