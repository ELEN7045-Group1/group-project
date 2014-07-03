using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IDBConnection dbConnection;

        public TaskRepository(IDBConnection _dbConnection)
        {
            dbConnection = _dbConnection;
        }
    }
}