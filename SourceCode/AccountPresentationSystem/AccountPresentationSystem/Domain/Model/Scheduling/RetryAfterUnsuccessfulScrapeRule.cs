using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class RetryAfterUnsuccessfulScrapeRule : IValueObject<RetryAfterUnsuccessfulScrapeRule>
    {
        private readonly ScheduleErrorType errorType;
        private readonly int retryInterval;

        public RetryAfterUnsuccessfulScrapeRule(ScheduleErrorType _errorType, int _retryInterval)
        {
            errorType = _errorType;
            retryInterval = _retryInterval;
        }

        public DateTime GetEarliestNextTaskTime()
        {
            // This function works out the earliets task time available based on the billing account;

            // Fake value for this prototype
            return DateTime.Now.AddHours(1);
        }

        public bool SameValueAs(RetryAfterUnsuccessfulScrapeRule other)
        {
            if ((other != null) && (other == this))
                return true;
            else
                return false;
        }
    }
}