using Newtonsoft.Json;

namespace GoogleSearchApplication
{
    public class ProxyEntity
    {
        public static string URL = string.Format("http://bigdata.api.bimt.com/v1/{0}", "/utils/googleScholar");
        [JsonProperty("ip")]
        private string ip;

        public string Ip
        {
            get { return ip; }
        }
        [JsonProperty("port")]
        private string port;

        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        public void StartUp()
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //设置代理可用 
            rk.SetValue("ProxyEnable", 1);
            //设置代理IP和端口 
            rk.SetValue("ProxyServer", ip + ":" + port);
            rk.Close();
        }

    }
}
