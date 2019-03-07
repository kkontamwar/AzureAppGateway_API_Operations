namespace FIConfiguration.BuisnessLayer
{
    public class Probe
    {
        public string Operation { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroupName { get; set; }
        public string ApplicationGatewayName { get; set; }
        public string ProbeName { get; set; }
        public string ProbeProtocol { get; set; }
        public string ProbeHost { get; set; }
        public string Probepath { get; set; }
    }

    public class InputData
	{
        private readonly Probe _probe = new Probe();

        public string HttpSettingsName { get; set; }
		public string HttpSettingsPort { get; set; }
		public string HttpSettingsProtocol { get; set; }

		public string BckendPoolName { get; set; }
		public string BckendipAddress { get; set; }

        public Probe Probe
        {
            get { return _probe; }
        }
    }

}