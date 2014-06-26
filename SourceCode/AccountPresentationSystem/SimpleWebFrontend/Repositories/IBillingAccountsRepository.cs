using AccountPresentationSystem.Domain.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebFrontend.Repositories
{
    public interface IBillingAccountsRepository
    {
        List<BillingAccount> GetBillingAccountsForUserID(string UserID);
        bool InsertBillingAccount(BillingAccount BA);
        bool UpdateBillingAccount(BillingAccount BA);
    }
}
