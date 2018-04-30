using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace BeginningAzureServerlessArchitecture
{
    public static class CalculateTransactionInformationStep2
    {
        [FunctionName("CalculateTransactionInformation")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var message = req.Content.ReadAsStringAsync().Result;

            List<Transaction> transactions = new List<Transaction>();
            try
            {
                transactions.AddRange(JsonConvert.DeserializeObject<List<Transaction>>(message));
            }
            catch (Exception e)
            {
                return req.CreateErrorResponse(HttpStatusCode.BadRequest, "The request did not match the required schema");
            }

            return req.CreateResponse(HttpStatusCode.OK, "Hello");
        }
    }
}
