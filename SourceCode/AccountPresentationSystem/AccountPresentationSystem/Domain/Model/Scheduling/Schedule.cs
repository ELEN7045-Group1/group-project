using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class Schedule 
    {
        public DateTime StartTime { get; set; }
        public TimeSpan ScrapeWindow { get; set; }

       // private IScheduleRepository scheduleRepository;

        public Schedule(/*IScheduleRepository ScheduleRepo*/)
        {
           // scheduleRepository = ScheduleRepo;
            
        }
    }

    
}