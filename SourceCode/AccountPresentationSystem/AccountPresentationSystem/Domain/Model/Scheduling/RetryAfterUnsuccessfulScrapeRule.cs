using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class RetryAfterUnsuccessfulScrapeRule : IValueObject<RetryAfterUnsuccessfulScrapeRule>
    {
        public ScheduleErrorType ErrorType { get; set; }
        public int RetryInterval { get; set; }

        public RetryAfterUnsuccessfulScrapeRule(ScheduleErrorType errorType, int retryInterval)
        {
            ErrorType = errorType;
            RetryInterval = retryInterval;
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