using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctions.Functions
{
    public class TimerTriggeredFunc
    {
        [FunctionName("TimerTriggeredFunc")]
        public void Run([TimerTrigger("* * * * * */5")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
