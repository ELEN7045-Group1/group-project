namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Model.StatementHandler;
    using AccountPresentationSystem.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class DataIntegrityRule :IValueObject<DataIntegrityRule>
    {
        public DataIntegrityRule()
        {
            CheckResult = true;
        }

        private Statement statement;

        public Statement Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        
        private bool checkResult;

        public bool CheckResult
        {
            get { return checkResult; }
            set { checkResult = value; }
        }

        public bool PerformAdditionCheck()
        {
            return CheckResult;
        }

        public bool PerformVATCheck()
        {
            return CheckResult;
        }

        public bool PerformDuplicateCheck()
        {
            return CheckResult;
        }

        public bool SameValueAs(DataIntegrityRule other)
        {
            return true;
        }
    }
}