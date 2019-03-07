using FIConfiguration.API_Operations;
using FIConfiguration.BuisnessLayer;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FIConfiguration
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<string> Get(string ClientId, string username, string password)
        {
            string clientId = "9cf11af2-b7dd-4081-af7f-98f3d34b4737";

            List<string> lst = new List<string>();
            var credentials = new UserPasswordCredential("", "");
            var authContext = new AuthenticationContext("https://login.microsoftonline.com/414e96d3-f8a4-4c10-b323-11fa8ebfe195/oauth2/token"); //https://login.microsoftonline.com/414e96d3-f8a4-4c10-b323-11fa8ebfe195/oauth2/token
                                                                                                                                                //var authContext = new AuthenticationContext("https://login.microsoftonline.com/common/oauth2/authorize");


            var authResult = await authContext.AcquireTokenAsync("https://managment.azure.com/", clientId, credentials);
            if (authResult == null)
            {
                lst.Add("Error");
                // return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Member Not Found");
            }

            return null;

            //var credentials = SdkContext.AzureCredentialsFactory.FromServicePrincipal(clientId, clientSecret, tenantId, AzureEnvironment.AzureGlobalCloud);
            //var azure = Azure.Configure().Authenticate(credentials).WithSubscription(subscriptionID);
            //var resourecelist = azure.ResourceGroups.List().ToList();

            //var serviceCreds = await ApplicationTokenProvider.LoginSilentAsync(tenantId, clientId, secret);
            //var resourceClient = new ResourceManagementClient(serviceCreds);
            //resourceClient.SubscriptionId = subscriptionID;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        /// <summary>
        /// 1. Create Probe
        /// 2. 
        /// </summary>
        /// <param name="value"></param>
        // PUT api/values/5
        public void Put(InputData value)
        {


            switch (value.Probe.Operation)
            {
                case "applicationGatewaysGet":
                    RootObject gatewayObject = GatewayUpdatePropertiesSteps.GetApplicationGateWay(value);
                    RootObject AddedProbeObject = GatewayUpdatePropertiesSteps.AddProbe(gatewayObject, value); //***tested working**
                                                                                                               //RootObject AddedhttpSettingObject = GatewayUpdatePropertiesSteps.AddHTTPSettings(AddedProbeObject, value);

                    RootObject AddedhttpSettingObject = GatewayUpdatePropertiesSteps.AddHTTPSettings(AddedProbeObject, value);
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(AddedProbeObject);
                    var apiurl = String.Format(Constant.applicationGatewaysAPI, value.Probe.SubscriptionId, value.Probe.ResourceGroupName, value.Probe.ApplicationGatewayName);

                    WebApiOperation.ExecutivePutAPI(apiurl, jsonString);

                    break;
                default:
                    break;
            }
        }



        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }


}
