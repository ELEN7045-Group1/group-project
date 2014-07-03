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
    }
}