using AccountPresentationSystem.Domain.Model.StatementHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    public class DataIntegrityChecker
    {
        private Statement _statement;

        public Statement statement
        {
            get { return _statement; }
            set { _statement = value; }
        }

        public DataIntegrityChecker(Statement statement)
        {
            if (statement != null)
                this.statement = statement;
            else
                throw new ArgumentNullException();
        }
    }
}