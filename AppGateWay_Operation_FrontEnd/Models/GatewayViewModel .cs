using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppGateWay_Operation_FrontEnd.Models
{
    public class GatewayViewModel
    {
        //public Operations operation { set; get; }
        public string operation { set; get; }
        public string SubscriptionId { get; set; }
        public string ResourceGroupName { get; set; }
        public string ApplicationGatewayName { get; set; }
        public string ProbeName { get; set; }
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string Probepath { get; set; }

        public string HttpSettingsName { get; set; }
        public string HttpSettingsPort { get; set; }
        public string BckendPoolName { get; set; }
        public string BckendipAddress { get; set; }

        public string RuleName { get; set; }
        public string RulePath { get; set; }

        public string brearerToken { get; set; }
    }

    public enum Operations
    {
        CreateProbe,
        AddHTTPSettings,
        BackendAddressPool,
        AddRule
    }


}
