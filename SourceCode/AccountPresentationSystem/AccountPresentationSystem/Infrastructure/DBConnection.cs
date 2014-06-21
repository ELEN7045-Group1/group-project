using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Infrastructure
{
    public class DBConnection : IDBConnection
    {
        public DataTable SelectQuery(string SQL)
        {
            // This would perform a select query based on the SQL entered in, and return a datatable;

            return new DataTable();
        }

        public int ExecuteStatement(string SQL)
        {
            // This would run an insert, update or delete statement, and return the number of rows affected.

            return 1;
        }
    }
}