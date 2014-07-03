using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class WindowPeriodRule : IValueObject<WindowPeriodRule>
    {
        private readonly TimeOfDay openPeriod;
        private readonly TimeOfDay closePeriod;

        public WindowPeriodRule(TimeOfDay OpenPeriod, TimeOfDay ClosePeriod)
        {
            openPeriod = OpenPeriod;
            closePeriod = ClosePeriod;
        }

        public DateTime GetEarliestNextTaskTime()
        {
            // This function works out the earliets task time available based on the billing account;

            // Fake value for this prototype
            return DateTime.Now.AddHours(1);
        }

        public bool SameValueAs(WindowPeriodRule other)
        {
            if (other != null)
                if ((other.openPeriod == this.openPeriod) &&
                    (other.closePeriod == this.closePeriod))
                    return true;
                else
                    return false;
            else
                return false;
        }
    }
}