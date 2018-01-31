using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace StarfallWindowsServiceHost
{
    public partial class StarfallServiceHost : ServiceBase
    {
        ServiceHost host;

        public StarfallServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(Starfall.StarfallServices.StarfallPlayService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
