using AccountPresentationSystem.Domain.Model.Billing;
using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class Schedule : IValueObject<Schedule>
    {
        private DateTime StartTime;
        private BillingAccountId BillingAccount;

        private List<WindowPeriodRule> WindowPeriods;
        private StatementLifeCycleRule StatementLifecycle;
        private List<RetryAfterUnsuccessfulScrapeRule> RetryRules;

        public Schedule(List<WindowPeriodRule> windowPeriods, StatementLifeCycleRule statementLifeCycle, List<RetryAfterUnsuccessfulScrapeRule> retryRules, DateTime startTime, BillingAccountId billingAccount)
        {
            WindowPeriods = windowPeriods;
            StatementLifecycle = statementLifeCycle;
            RetryRules = retryRules;
            StartTime = startTime;
            BillingAccount = billingAccount;
        }

        public bool SameValueAs(Schedule other)
        {
            if ((other != null) && (other == this))
                return true;
            else
                return false;
        }
    }

    
}