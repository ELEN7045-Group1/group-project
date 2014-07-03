using AccountPresentationSystem.Domain.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class ScrapeTaskFactory : IScrapeTaskFactory
    {
        public ScrapeTaskFactory()
        {
        }

        public ScrapeTask NewScrapeTask(BillingAccount billingAccount)
        {
            // This method builds a new task with its dependencies and returns it to the caller
            // All build logic is encapsulated in this method
            
            // Values are derived from the billingAccount object

            // The 3 rule types are created to exist with the task for future use, which could be 
            // a retry after a scrape failed, and so on.

            // For the purposes of this prototype, some fake values will be entered
            StatementLifeCycleRule lifeCycleRule = new StatementLifeCycleRule(30, 5, 2);
            
            List<RetryAfterUnsuccessfulScrapeRule> retryRules = new List<RetryAfterUnsuccessfulScrapeRule>();
            retryRules.Add(new RetryAfterUnsuccessfulScrapeRule(ScheduleErrorType.APSError, 5));
            retryRules.Add(new RetryAfterUnsuccessfulScrapeRule(ScheduleErrorType.NoNewStatementError, 6));
            retryRules.Add(new RetryAfterUnsuccessfulScrapeRule(ScheduleErrorType.ScraperError, 7));

            List<WindowPeriodRule> windowPeriods = new List<WindowPeriodRule>();
            windowPeriods.Add(new WindowPeriodRule(new TimeOfDay(1, 0, 0), new TimeOfDay(6, 0, 0)));
            windowPeriods.Add(new WindowPeriodRule(new TimeOfDay(19, 0, 0), new TimeOfDay(23, 0, 0)));


            ScrapeTask newTask = new ScrapeTask(Guid.NewGuid().ToString(), billingAccount.BillingAccountId.ToString(), windowPeriods, retryRules, lifeCycleRule);
            return newTask;
        }

    }
}