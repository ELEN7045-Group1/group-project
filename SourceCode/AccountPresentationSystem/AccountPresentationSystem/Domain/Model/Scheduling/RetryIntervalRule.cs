using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class RetryIntervalRule : IScheduleRule
    {
        public bool RuleIsSatisfiedBy(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}