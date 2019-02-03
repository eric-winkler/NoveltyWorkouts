using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace NoveltyWorkouts
{
    public static class MovementFunction
    {
        [FunctionName("Movement")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var movement = MovementGenerator.Generate();
            log.LogInformation($"Generated '{movement}'");
            return new OkObjectResult(movement);
        }
    }
}
