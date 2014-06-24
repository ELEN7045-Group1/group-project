using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class StatementRepository
    {
        private readonly IDBConnection dataConnection;

        public StatementRepository()
        {
            
        }

        public bool SaveStatement()
        {
            //This method will save the statement to the the statement repo didn't build the logic here
            return true;
        }

        public List<Statement> GetStatement()
        {
            //This method will save the statement to the the statement repo didn't build the logic here
            List<Statement> _statement = new List<Statement>();
            return _statement;
        }
    }
}