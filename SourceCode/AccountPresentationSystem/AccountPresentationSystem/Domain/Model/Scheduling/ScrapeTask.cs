using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;
using AccountPresentationSystem.Domain.Model.Billing;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class ScrapeTask
    {
        private readonly string billingAccountID;
        private readonly ScrapeTaskStatus taskStatus;
        private readonly DateTime scrapeStart;
        private readonly List<WindowPeriodRule> windowPeriodrules;
        private readonly List<RetryAfterUnsuccessfulScrapeRule> retryRules;
        private readonly StatementLifeCycleRule lifeCycleRule;

        public ScrapeTaskStatus TaskStatus
        {
            get
            {
                return taskStatus;
            }
        }

        public DateTime ScrapeStart
        {
            get
            {
                return scrapeStart;
            }
        }

        public ScrapeTask(string _billingAccountID, List<WindowPeriodRule> _windowPeriodrules, List<RetryAfterUnsuccessfulScrapeRule> _retryRules, StatementLifeCycleRule _lifeCycleRule)
        {
            billingAccountID = _billingAccountID;
            windowPeriodrules = _windowPeriodrules;
            retryRules = _retryRules;
            lifeCycleRule = _lifeCycleRule;

            // This constructor constructs the ScrapeTask class based on the billing account details
            taskStatus = ScrapeTaskStatus.Pending;
            scrapeStart = SetEarliestTaskTime();

        }

        private DateTime SetEarliestTaskTime()
        {
            // This method sets the earliest possible start times based on the attached rules

            //Fake value for this prototype
            return DateTime.Now.AddHours(1);
        }
    }
}