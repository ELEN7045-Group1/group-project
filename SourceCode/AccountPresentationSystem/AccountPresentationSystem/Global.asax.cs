using AccountPresentationSystem.App_Start;
using AccountPresentationSystem.Application;
using AccountPresentationSystem.Domain.Model.Scheduling;
using AccountPresentationSystem.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Security;
using System.Web.SessionState;

namespace AccountPresentationSystem
{
    public class Global : System.Web.HttpApplication
    {
        BackgroundWorker scheduleBackgroundworker;

        protected void Application_Start(object sender, EventArgs e)
        {

            GlobalConfiguration.Configure(Bootstrapper.Setup);

            //Start Schedule.
            scheduleBackgroundworker = new BackgroundWorker();
            scheduleBackgroundworker.WorkerSupportsCancellation = true;
            scheduleBackgroundworker.DoWork += scheduleBackgroundworker_DoWork;
            scheduleBackgroundworker.RunWorkerAsync();

        }

        private void scheduleBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            IDependencyResolver container = GlobalConfiguration.Configuration.DependencyResolver;
            ISchedule ScrapeTaskSchedule = (ISchedule)container.GetService(typeof(ISchedule));

            if (ScrapeTaskSchedule != null)
            {
                while (!scheduleBackgroundworker.CancellationPending)
                    ScrapeTaskSchedule.CreateNewTasks();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            int TimeoutCount = 0;

            while ((scheduleBackgroundworker.IsBusy) && (TimeoutCount < 20))
            {
                scheduleBackgroundworker.CancelAsync();
                Thread.Sleep(100);
                TimeoutCount++;
            }

            scheduleBackgroundworker.Dispose();
            scheduleBackgroundworker = null;
        }
    }
}