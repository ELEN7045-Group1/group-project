using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class ScrapeTask
    {
        private string BillingAccountID;

        public Enumeration.ScrapeTaskStatus TaskStatus { get; set; }
        public DateTime ScrapeStart { get; set; }

        public ScrapeTask()
        {

        }


    }
}