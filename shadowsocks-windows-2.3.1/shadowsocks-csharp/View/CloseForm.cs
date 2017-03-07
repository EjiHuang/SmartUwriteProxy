using Shadowsocks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class CloseForm : Form
    {
        ShadowsocksController controller;
        public CloseForm(ShadowsocksController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public static Process GetProcess(string name)
        {
            Process[] arrayP = Process.GetProcesses();
            foreach (Process item in arrayP)
            {
                if (item.ProcessName.Contains(name))
                {
                    return item;
                }
            }
            return null;
        }

        public void CloseFrm()
        {
            controller.Stop();
            //_notifyIcon.Visible = false;
            Application.Exit();
            string softName = "BimtShadowsocks";
            Process p = GetProcess(softName);
            if (p != null)
            {
                p.Kill();
            }
            this.FindForm().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFrm();
        }
    }
}
