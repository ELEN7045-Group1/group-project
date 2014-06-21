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
        IDBConnection dataConnection;

        public ScheduleRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        public IList<Schedule> GetAllSchedules()
        {
            IList<Schedule> ReturnList = new List<Schedule>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve All Schedules");

            foreach (DataRow dr in dt.Rows)
            {
                Schedule SchedItem = new Schedule() {
                    StartTime = Convert.ToDateTime(dr["StartTime"]),
                    ScrapeWindow = new TimeSpan(Convert.ToInt64(dr["TimeSpan"]))
                };

                ReturnList.Add(SchedItem);
            }

            return ReturnList;
        }
    }
}