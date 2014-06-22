using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    interface IScheduleRule
    {
        bool RuleIsSatisfiedBy(Schedule schedule);
    }
}
