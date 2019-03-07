using FIConfiguration.API_Operations;
using Newtonsoft.Json;
using System;
using System.Text;

namespace FIConfiguration.BuisnessLayer
{
	public static class GatewayUpdatePropertiesSteps
	{

		public static RootObject GetApplicationGateWay(InputData value)
		{
			var geturl = String.Format(Constant.applicationGatewaysAPI, value.Probe.SubscriptionId, value.Probe.ResourceGroupName, value.Probe.ApplicationGatewayName);
			string gatewayDetails = WebApiOperation.ExecutiveGetAPI(geturl);
			var result = JsonConvert.DeserializeObject<RootObject>(gatewayDetails);
			return result;
		}


		public static RootObject AddBackendAddressPool(RootObject gatewayObject, InputData value)
		{
			string backendAddressPoolJson = "{        \"name\": \"bckendPoolName\",        \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/bckendPoolResourceGroupName/providers/Microsoft.Network/applicationGateways/bckendPoolApplicationGatewayName/backendAddressPools/appGatewayBackendPool\",        \"etag\": \"W/\\\"8f6a4a08-26ab-4810-a9cf-b3c5dc9d24dc\\\"\",        \"properties\": {          \"provisioningState\": \"Succeeded\",          \"backendAddresses\": [            {              \"ipAddress\": \"bckendPoolIPAddress\"            }          ],          \"urlPathMaps\": [],          \"pathRules\": []        },        \"type\": \"Microsoft.Network/applicationGateways/backendAddressPools\" }";
			StringBuilder sb = new StringBuilder(backendAddressPoolJson);
			sb.Replace("bckendPoolName", value.BckendPoolName);
			sb.Replace("bckendPoolResourceGroupName", value.Probe.ResourceGroupName);
			sb.Replace("bckendPoolApplicationGatewayName", value.Probe.ApplicationGatewayName);
			sb.Replace("bckendPoolIPAddress", value.BckendipAddress);
			BackendAddressPool AddProbeObject = JsonConvert.DeserializeObject<BackendAddressPool>(sb.ToString());
			gatewayObject.properties.backendAddressPools.Add(AddProbeObject);
			return gatewayObject;
		}

		public static RootObject AddHTTPSettings(RootObject gatewayObject, InputData value)
		{
			int HttpSettingsPort =Convert.ToInt32(value.HttpSettingsPort);
			string httpSettingsJson = "{        \"name\": \"HttpSettingsName\",        \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/HttpSettingsResourceGroupName/providers/Microsoft.Network/applicationGateways/HttpSettingsApplicationGatewayName/backendHttpSettingsCollection/HttpSettingsResourceGroupName\",        \"etag\": \"W/\\\"eeac3f6f-1ab0-4d02-8df3-cc4b70137c69\\\"\",        \"properties\": {          \"provisioningState\": \"Succeeded\",          \"port\":" + HttpSettingsPort + " ,          \"protocol\": \"HttpSettingsProtocol\",          \"cookieBasedAffinity\": \"Disabled\",          \"hostName\": null,          \"pickHostNameFromBackendAddress\": false,          \"affinityCookieName\": \"ApplicationGatewayAffinity\",          \"path\": null,          \"requestTimeout\": 30,          \"urlPathMaps\": [],          \"pathRules\": []        },        \"type\": \"Microsoft.Network/applicationGateways/backendHttpSettingsCollection\"      }          ";
			//string httpSettingsJson = "{        \"name\": \"HttpSettingsName\",        \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/HttpSettingsResourceGroupName/providers/Microsoft.Network/applicationGateways/HttpSettingsApplicationGatewayName/backendHttpSettingsCollection/HttpSettingsName\",        \"etag\": \"W/\\\"eeac3f6f-1ab0-4d02-8df3-cc4b70137c69\\\"\",        \"properties\": {          \"provisioningState\": \"Succeeded\",          \"port\":\"HttpSettingsPort\" ,          \"protocol\": \"HttpSettingsProtocol\",          \"cookieBasedAffinity\": \"Disabled\",          \"hostName\": null,          \"pickHostNameFromBackendAddress\": false,          \"affinityCookieName\": \"ApplicationGatewayAffinity\",          \"path\": null,          \"requestTimeout\": 30,          \"urlPathMaps\": [            {              \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/NowCloudConnectRG/providers/Microsoft.Network/applicationGateways/NowCloudConnectAppGW/urlPathMaps/NowCloudConnectPathRule\"            }          ],          \"pathRules\": [            {              \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/NowCloudConnectRG/providers/Microsoft.Network/applicationGateways/NowCloudConnectAppGW/urlPathMaps/NowCloudConnectPathRule/pathRules/FIA\"            }          ]        },        \"type\": \"Microsoft.Network/applicationGateways/backendHttpSettingsCollection\"      }          ";
			StringBuilder sb = new StringBuilder(httpSettingsJson);
			sb.Replace("HttpSettingsResourceGroupName", value.Probe.ResourceGroupName);
			sb.Replace("HttpSettingsApplicationGatewayName", value.Probe.ApplicationGatewayName);
			sb.Replace("HttpSettingsName", value.HttpSettingsName);
			//sb.Replace("HttpSettingsPort", value.HttpSettingsPort);
			sb.Replace("HttpSettingsProtocol", value.HttpSettingsProtocol);
			//BackendHttpSettingsCollectionN AddProbeObject = JsonConvert.DeserializeObject<BackendHttpSettingsCollectionN>(httpSettingsJson);
			//gatewayObject.properties.backendHttpSettingsCollection.Add(AddProbeObject);
			return gatewayObject;
		}

		public static RootObject AddProbe(RootObject gatewayObject, InputData value)
		{
			string probJson = "{        \"name\": \"ProbeName\",        \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/ProbeResourceGroupName/providers/Microsoft.Network/applicationGateways/ProbeApplicationGatewayName/probes/ProbeName\",        \"etag\": \"W/\\\"8f6a4a08-26ab-4810-a9cf-b3c5dc9d24dc\\\"\",        \"properties\": {          \"provisioningState\": \"Succeeded\",          \"protocol\": \"ProbeProtocol\",          \"host\": \"ProbeHost\",          \"path\": \"Probepath\",          \"interval\": 30,          \"timeout\": 30,          \"unhealthyThreshold\": 20,          \"pickHostNameFromBackendHttpSettings\": false,          \"minServers\": 0,          \"match\": {            \"body\": \"\",            \"statusCodes\": [              \"200-399\"            ]          },          \"backendHttpSettings\": [            {              \"id\": \"/subscriptions/5d077714-2b1c-43d0-81f2-bc711d989167/resourceGroups/NowCloudConnectRG/providers/Microsoft.Network/applicationGateways/NowCloudConnectAppGW/backendHttpSettingsCollection/appGatewayBackendHttpSettings\"            }          ]        },        \"type\": \"Microsoft.Network/applicationGateways/probes\"      }";
			StringBuilder sb = new StringBuilder(probJson);
			sb.Replace("HttpResourceGroupName", value.Probe.ResourceGroupName);
			sb.Replace("HttpApplicationGatewayName", value.Probe.ApplicationGatewayName);
			sb.Replace("HttpSettingName", value.Probe.ProbeName);
			sb.Replace("ProbeHost", value.Probe.ProbeHost);
			sb.Replace("HttpProtocol", value.Probe.ProbeHost);
			sb.Replace("ProbeName", value.Probe.ProbeName);

			object AddProbeObject = JsonConvert.DeserializeObject<Object>(sb.ToString());
			gatewayObject.properties.probes.Add(AddProbeObject);
			return gatewayObject;
		}
	}
}