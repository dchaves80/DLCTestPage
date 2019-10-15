using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;

namespace Avast_Service
{
    [RunInstallerAttribute(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller1.Account = ServiceAccount.LocalService;
            this.serviceProcessInstaller1.Username = null;
            this.serviceProcessInstaller1.Password = null;
        }
    }
}
