using System.Collections.Generic;

namespace FIConfiguration.BuisnessLayer
{
	public class Sku
	{
		public string name { get; set; }
		public string tier { get; set; }
		public int capacity { get; set; }
	}

	public class Subnet
	{
		public string id { get; set; }
	}

	public class Properties2
	{
		public string provisioningState { get; set; }
		public Subnet subnet { get; set; }
	}

	public class GatewayIPConfiguration
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties2 properties { get; set; }
	}

	public class Properties3
	{
		public string provisioningState { get; set; }
		public string publicCertData { get; set; }
	}

	public class SslCertificate
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties3 properties { get; set; }
	}

	public class PublicIPAddress
	{
		public string id { get; set; }
	}

	public class Properties4
	{
		public string provisioningState { get; set; }
		public string privateIPAllocationMethod { get; set; }
		public PublicIPAddress publicIPAddress { get; set; }
	}

	public class FrontendIPConfiguration
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties4 properties { get; set; }
	}

	public class Properties5
	{
		public string provisioningState { get; set; }
		public int port { get; set; }
	}

	public class FrontendPort
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties5 properties { get; set; }
	}

	public class Properties6
	{
		public string provisioningState { get; set; }
		public List<object> backendAddresses { get; set; }
	}

	public class BackendAddressPool
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties6 properties { get; set; }
	}

	public class Properties7
	{
		public string provisioningState { get; set; }
		public int port { get; set; }
		public string protocol { get; set; }
		public string cookieBasedAffinity { get; set; }
		public int requestTimeout { get; set; }
	}

	public class BackendHttpSettingsCollection
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties7 properties { get; set; }
	}

	public class FrontendIPConfiguration2
	{
		public string id { get; set; }
	}

	public class FrontendPort2
	{
		public string id { get; set; }
	}

	public class SslCertificate2
	{
		public string id { get; set; }
	}

	public class Properties8
	{
		public string provisioningState { get; set; }
		public FrontendIPConfiguration2 frontendIPConfiguration { get; set; }
		public FrontendPort2 frontendPort { get; set; }
		public string protocol { get; set; }
		public SslCertificate2 sslCertificate { get; set; }
		public bool requireServerNameIndication { get; set; }
	}

	public class HttpListener
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties8 properties { get; set; }
	}

	public class DefaultBackendAddressPool
	{
		public string id { get; set; }
	}

	public class DefaultBackendHttpSettings
	{
		public string id { get; set; }
	}

	public class DefaultRewriteRuleSet
	{
		public string id { get; set; }
	}

	public class BackendAddressPool2
	{
		public string id { get; set; }
	}

	public class BackendHttpSettings
	{
		public string id { get; set; }
	}

	public class RewriteRuleSet
	{
		public string id { get; set; }
	}

	public class Properties10
	{
		public string provisioningState { get; set; }
		public List<string> paths { get; set; }
		public BackendAddressPool2 backendAddressPool { get; set; }
		public BackendHttpSettings backendHttpSettings { get; set; }
		public RewriteRuleSet rewriteRuleSet { get; set; }
	}

	public class PathRule
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties10 properties { get; set; }
	}

	public class Properties9
	{
		public string provisioningState { get; set; }
		public DefaultBackendAddressPool defaultBackendAddressPool { get; set; }
		public DefaultBackendHttpSettings defaultBackendHttpSettings { get; set; }
		public DefaultRewriteRuleSet defaultRewriteRuleSet { get; set; }
		public List<PathRule> pathRules { get; set; }
	}

	public class UrlPathMap
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties9 properties { get; set; }
	}

	public class HttpListener2
	{
		public string id { get; set; }
	}

	public class BackendAddressPool3
	{
		public string id { get; set; }
	}

	public class BackendHttpSettings2
	{
		public string id { get; set; }
	}

	public class RewriteRuleSet2
	{
		public string id { get; set; }
	}

	public class UrlPathMap2
	{
		public string id { get; set; }
	}

	public class Properties11
	{
		public string provisioningState { get; set; }
		public string ruleType { get; set; }
		public HttpListener2 httpListener { get; set; }
		public BackendAddressPool3 backendAddressPool { get; set; }
		public BackendHttpSettings2 backendHttpSettings { get; set; }
		public RewriteRuleSet2 rewriteRuleSet { get; set; }
		public UrlPathMap2 urlPathMap { get; set; }
	}

	public class RequestRoutingRule
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties11 properties { get; set; }
	}

	public class RequestHeaderConfiguration
	{
		public string headerName { get; set; }
		public string headerValue { get; set; }
	}

	public class ResponseHeaderConfiguration
	{
		public string headerName { get; set; }
		public string headerValue { get; set; }
	}

	public class ActionSet
	{
		public List<RequestHeaderConfiguration> requestHeaderConfigurations { get; set; }
		public List<ResponseHeaderConfiguration> responseHeaderConfigurations { get; set; }
	}

	public class RewriteRule
	{
		public string name { get; set; }
		public ActionSet actionSet { get; set; }
	}

	public class Properties12
	{
		public string provisioningState { get; set; }
		public List<RewriteRule> rewriteRules { get; set; }
	}

	public class RewriteRuleSet3
	{
		public string name { get; set; }
		public string id { get; set; }
		public Properties12 properties { get; set; }
	}

	public class Properties
	{
		public string provisioningState { get; set; }
		public Sku sku { get; set; }
		public string operationalState { get; set; }
		public List<GatewayIPConfiguration> gatewayIPConfigurations { get; set; }
		public List<SslCertificate> sslCertificates { get; set; }
		public List<object> authenticationCertificates { get; set; }
		public List<FrontendIPConfiguration> frontendIPConfigurations { get; set; }
		public List<FrontendPort> frontendPorts { get; set; }
		public List<BackendAddressPool> backendAddressPools { get; set; }
		public List<BackendHttpSettingsCollection> backendHttpSettingsCollection { get; set; }
		public List<HttpListener> httpListeners { get; set; }
		public List<UrlPathMap> urlPathMaps { get; set; }
		public List<RequestRoutingRule> requestRoutingRules { get; set; }
		public List<RewriteRuleSet3> rewriteRuleSets { get; set; }
		public List<object> probes { get; set; }
	}

	public class RootObject
	{
		public string name { get; set; }
		public string id { get; set; }
		public string type { get; set; }
		public string location { get; set; }
		public Properties properties { get; set; }
	}







}