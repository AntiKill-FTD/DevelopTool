using System.Net.NetworkInformation;

namespace Tool.Main.Config
{
    public class BaseConfig
    {
        public bool NetStat
        {
            get { return NetworkInterface.GetIsNetworkAvailable(); }
        }
    }
}
