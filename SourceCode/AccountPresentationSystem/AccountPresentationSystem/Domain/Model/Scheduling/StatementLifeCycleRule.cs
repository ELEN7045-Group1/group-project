using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class StatementLifeCycleRule : IValueObject<StatementLifeCycleRule>
    {
        private readonly int numOfDaysPerBillingCycle;
        private readonly int leadTimeInterval;
        private readonly int retryInterval;

        public StatementLifeCycleRule(int NumOfDaysPerBillingCycle, int LeadTimeInterval, int RetryInterval)
        {
            numOfDaysPerBillingCycle = NumOfDaysPerBillingCycle;
            leadTimeInterval = LeadTimeInterval;
            retryInterval = RetryInterval;
        }

        public DateTime GetEarliestNextTaskTime()
        {
            // This function works out the earliets task time available based on the billing account;

            // Fake value for this prototype
            return DateTime.Now.AddHours(1);
        }

        public bool SameValueAs(StatementLifeCycleRule other)
        {
            if ((other != null) && (other == this))
                return true;
            else
                return false;
        }
    }
}