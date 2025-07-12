using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace az204_function
{
    public class az204_http_trigger_function
    {
        private readonly ILogger<az204_http_trigger_function> _logger;

        public az204_http_trigger_function(ILogger<az204_http_trigger_function> logger)
        {
            _logger = logger;
        }

        [Function("az204_http_trigger_function")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
