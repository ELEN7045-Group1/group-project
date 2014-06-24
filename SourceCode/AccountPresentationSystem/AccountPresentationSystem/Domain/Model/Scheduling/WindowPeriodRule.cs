using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class WindowPeriodRule : IValueObject<WindowPeriodRule>
    {
        private TimeOfDay openPeriod;
        private TimeOfDay closePeriod;

        public WindowPeriodRule(TimeOfDay OpenPeriod, TimeOfDay ClosePeriod)
        {
            openPeriod = OpenPeriod;
            closePeriod = ClosePeriod;
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