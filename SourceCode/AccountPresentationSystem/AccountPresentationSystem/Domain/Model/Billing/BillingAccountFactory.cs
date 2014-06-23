namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Service;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class BillingAccountFactory
    {
        public static BillingAccount NewBillingAccount(string billingCompanyIdString,
            string billingAccountUsername, string billingAccountPassword)
        {
            //billing account id string formulation, calls a service to perform action
            IBillingAccountService billingAccountService = new BillingAccountService();
            string localBillingAccountIdString = billingAccountService.CreateBillingAccountId();
            BillingAccountId localBillingAccountId = new BillingAccountId(localBillingAccountIdString);

            BillingCompanyId localBillingCompanyId = new BillingCompanyId(billingCompanyIdString);

            return new BillingAccount(localBillingAccountId, localBillingCompanyId, billingAccountUsername, billingAccountPassword);
        }

    }
}