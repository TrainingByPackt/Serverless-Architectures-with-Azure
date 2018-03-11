using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BeginningAzureServerlessArchitecture.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace BeginningAzureServerlessArchitecture
{
    public static class LessonOne
    {
        [FunctionName("LessonOne")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "Transactions")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            var message = await req.Content.ReadAsStringAsync();
            var transaction = JsonConvert.DeserializeObject<Transaction>(message);

            return req.CreateResponse(HttpStatusCode.OK, $"You made a transaction of £{transaction.Amount}!");
        }
    }
}
