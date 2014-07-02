namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class DataIntegrityRule :IValueObject<DataIntegrityRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APSUser"/> class.
        /// </summary>
        /// <param name="apsUserId">The aps user identifier.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// 
        public DataIntegrityRule()
        {
            CheckResult = true;
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