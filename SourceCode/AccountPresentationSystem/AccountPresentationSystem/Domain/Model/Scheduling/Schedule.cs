using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class Schedule : IValueObject<Schedule>
    {
        public DateTime StartTime { get; set; }
        public TimeSpan ScrapeWindow { get; set; }

       // private IScheduleRepository scheduleRepository;

        public Schedule(/*IScheduleRepository ScheduleRepo*/)
        {
           // scheduleRepository = ScheduleRepo;

            
        }

        public bool SameValueAs(Schedule other)
        {
            if (other != null)
                if ((other.StartTime == this.StartTime) &&
                    (other.ScrapeWindow == this.ScrapeWindow))
                    return true;
                else
                    return false;
            else
                return false;
        }
    }

    
}