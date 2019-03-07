using AppGateWay_Operation_FrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AppGateWay_Operation_FrontEnd.API_Operation
{
    public class ApiOperations
    {
        public static HttpStatusCode ExecutivePutApi(string apiUri, GatewayViewModel probObject)
        {
            string jsonInput = JsonConvert.SerializeObject(probObject);
            var httpContent = new StringContent(jsonInput, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(apiUri);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", probObject.brearerToken);
                    var responseTask = client.PutAsync(apiUri, httpContent);
                    responseTask.Wait();
                    var result = responseTask.Result;

                    return result.StatusCode;

                }
                catch (HttpRequestException)
                {
                    //Console.WriteLine(e.InnerException.Message);
                    return HttpStatusCode.BadRequest;
                }
            }

        }

        public class CustomSettings
        {
            public string azureLogUrl { get; set; }
        }
    }
}
