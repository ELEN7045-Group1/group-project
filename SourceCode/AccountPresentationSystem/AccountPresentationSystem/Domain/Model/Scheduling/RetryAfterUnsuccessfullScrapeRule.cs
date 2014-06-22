using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class RetryAfterUnsuccessfullScrapeRule : IScheduleRule, IValueObject<RetryAfterUnsuccessfullScrapeRule>
    {
        public bool SameValueAs(RetryAfterUnsuccessfullScrapeRule other)
        {
            throw new NotImplementedException();
        }
    }
}