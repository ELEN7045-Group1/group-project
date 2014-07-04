namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Model.Billing;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class DataIntegrityCustomRule : DataIntegrityRule
    {
        private BillingCompanyId billingCompanyID;

        public BillingCompanyId BillingCompanyID
        {
            get { return billingCompanyID; }
            set { billingCompanyID = value; }
        }

        public DataIntegrityCustomRule(BillingCompanyId _billingCompanyID)
        {
            BillingCompanyID = _billingCompanyID;
        }
    }
}