using System;

namespace GoogleSearchApplication
{
    public abstract class BaseProxy<T>
    {
        protected string ip ;


        protected string port;

        public void SetIp(string p)
        {
            ip = p;
        }
       
        public void SetPort(string p)
        {
            port = p;
        }

        public static void ShutDown()
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //设置代理不可用 
            rk.SetValue("ProxyEnable", 0);
            rk.Close();
        }

        private void StartUp(string ip, string port)
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //设置代理可用 
            rk.SetValue("ProxyEnable", 1);
            //设置代理IP和端口 
            rk.SetValue("ProxyServer", ip + ":" + port);
            rk.Close();
        }

        public abstract string GetIp();
        public abstract string GetPort();
        public void InitProxy()
        {
            try
            {
                ip = GetIp();
                port = GetPort();
                StartUp(ip, port);
                //Log4Net.LogHelper.WriteLog(typeof(BaseProxy), ip + ":" + port);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
