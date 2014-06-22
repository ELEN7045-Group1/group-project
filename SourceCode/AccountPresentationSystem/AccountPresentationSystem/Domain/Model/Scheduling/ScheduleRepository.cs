using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly IDBConnection dataConnection;

        public ScheduleRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        public List<Schedule> GetAllSchedules()
        {
            // This retrieves all schedules via the DBConnetion

            List<Schedule> ReturnList = new List<Schedule>();
            return ReturnList;
        }
    }
}