using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            timer.Interval = 30000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Tick);
            timer.Enabled = true;
            Library.WriteErrorLog("Windows service started");

        }

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            Library.WriteErrorLog("job has been done successfully");

        }

        protected override void OnStop()
        {
            timer.Enabled =false;
            Library.WriteErrorLog("Windows service stopped");
        }
    }
}
