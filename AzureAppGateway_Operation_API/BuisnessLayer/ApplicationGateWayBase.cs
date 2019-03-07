using System;

namespace FIConfiguration.BuisnessLayer
{
	public class ApplicationGateWayBase
	{
		public String ResourceGroupName { get; set; }
		public String ApplicationGatewayName { get; set; }
		public string Apiversion { get; set; }
	}
}