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
            {
                this.statement = statement;
                ApplyIntegrityRules(this.statement);
            }
            else
                throw new ArgumentNullException();
        }

        private void ApplyIntegrityRules(Statement statement)
        {
            DataIntegrityRule dir = new DataIntegrityRule();
            dir.Statement = statement;
        }
    }
}