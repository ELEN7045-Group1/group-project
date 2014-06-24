using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class StatementLifeCycleRule : IValueObject<StatementLifeCycleRule>
    {
        public int numOfDaysPerBillingCycle;
        public int leadTimeInterval;
        public int retryInterval;

        public StatementLifeCycleRule(int NumOfDaysPerBillingCycle, int LeadTimeInterval, int RetryInterval)
        {
            numOfDaysPerBillingCycle = NumOfDaysPerBillingCycle;
            leadTimeInterval = LeadTimeInterval;
            retryInterval = RetryInterval;
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