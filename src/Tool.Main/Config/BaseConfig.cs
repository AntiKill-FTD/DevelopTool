using System.Net.NetworkInformation;

namespace Tool.Main.Config
{
    public static class BaseConfig
    {
        /// <summary>
        /// 获取网络状态
        /// </summary>
        public static bool NetStat
        {
            get { return NetworkInterface.GetIsNetworkAvailable(); }
        }
    }
}
