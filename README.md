# SmartUwriteProxy base on Shadowsocks 2.3.1#
- 基于shadowsocks二次开发的代理工程，从接口获取代理地址，进行代理控制，同时启动时需要身份验证；

![](http://i.imgur.com/lDt0mZ9.jpg)

	    using Newtonsoft.Json;
		using Newtonsoft.Json.Linq;
		using Shadowsocks.Controller;
		using Shadowsocks.Model;
		using Shadowsocks.Properties;
		using Shadowsocks.View;
		using System;
		using System.Collections.Generic;
		using System.Diagnostics;
		using System.IO;
		using System.Threading;
		using System.Windows.Forms;
		
		namespace Shadowsocks
		{
	    static class Program
	    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            
            LoadBimtProxySetting(args);
            Util.Utils.ReleaseMemory();
            using (Mutex mutex = new Mutex(false, "Global\\" + "71981632-A427-497F-AB91-241CD227EC1F"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!mutex.WaitOne(0, false))
                {
                    Process[] oldProcesses = Process.GetProcessesByName("Shadowsocks");
                    if (oldProcesses.Length > 0)
                    {
                        Process oldProcess = oldProcesses[0];
                    }
                    MessageBox.Show("Shadowsocks is already running.\n\nFind Shadowsocks icon in your notify tray.");
                    return;
                }
                Directory.SetCurrentDirectory(Application.StartupPath);
				#if !DEBUG
                Logging.OpenLogFile();
				#endif
                ShadowsocksController controller = new ShadowsocksController();

                MenuViewController viewController = new MenuViewController(controller);

                controller.Start();
                Process.Start("https://scholar.google.com.hk/schhp?hl=zh-CN");
                Application.Run();
            }
        }

        class ProxyServer
        {
            [JsonProperty("server")]
            public string server=string.Empty;
            [JsonProperty("password")]
            public string password=string.Empty;
            [JsonProperty("server_port")]
            public int server_port=0;
        }

        public static void LoadBimtProxySetting(string[] args)
        {
            try
            {
                //param= "[{\"server\":\"107.182.182.93\",\"password\":\"NjcyNmZlMj\",\"server_port\":\"443\"},{\"server\":\"23.106.157.237\",\"password\":\"ODEyNDg3NW\",\"server_port\":\"443\"},{\"server\":\"23.83.237.70\",\"password\":\"ODcwYTdkYT\",\"server_port\":\"443\"}]";
                //MessageBox.Show(string.Format("ip:{0} port:{1} pwd:{2}", args[0], args[2], args[1]));
                Configuration cfg = Configuration.Load();
                Random ro = new Random();
                cfg.localPort = ro.Next(5000, 65534);
                cfg.enabled = true;
                cfg.configs.Clear();
                Server server = new Server();
                server.method = "aes-256-cfb";
                server.server = args[0];
                server.password = args[1];
                server.server_port = int.Parse(args[2]);
                cfg.configs.Add(server);
                Configuration.Save(cfg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
	    }
		}
