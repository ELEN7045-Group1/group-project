using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class ScrapeTaskRepository : IScrapeTaskRepository
    {
        private readonly IDBConnection dbConnection;

        public ScrapeTaskRepository(IDBConnection _dbConnection)
        {
            dbConnection = _dbConnection;
        }

        public void SaveScrapeTask(ScrapeTask task)
        {
            // This will save the scrapetask to the db connection
        }

        public List<ScrapeTask> GetAllScrapeTask()
        {
            List<ScrapeTask> retVal = new List<ScrapeTask>();

            // Fake data
            List<WindowPeriodRule> windowPeriods = new List<WindowPeriodRule>();
            List<RetryAfterUnsuccessfulScrapeRule> retryRules = new List<RetryAfterUnsuccessfulScrapeRule>();

            retVal.Add(new ScrapeTask(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), windowPeriods, retryRules, new StatementLifeCycleRule(0, 0, 0)));

            return retVal;
        }
    }
}