namespace AccountPresentationSystem.Domain.Model.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IBillingAccountRepository
    {
        List<BillingAccount> GetAllBillingAccounts();
        List<BillingAccount> GetAllBillingAccountsWithNoScrapeTasks();
    }
}