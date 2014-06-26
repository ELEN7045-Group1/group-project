using AccountPresentationSystem.Domain.Model.Billing;
using SimpleWebFrontend.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebFrontend.Repositories
{
    public class FakeBillingAccountsRepository :IBillingAccountsRepository
    {
        public List<BillingAccount> GetBillingAccountsForUserID(string UserID)
        {
            return FakeData.BillingAccounts.Where(x => x.APSUser.APSUserId.IdString == UserID).ToList();
        }

        public bool InsertBillingAccount(BillingAccount BA)
        {
            try
            {
                FakeData.BillingAccounts.Add(BA);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBillingAccount(BillingAccount BA)
        {
            try
            {
                int index = FakeData.BillingAccounts.FindIndex(x => x.BillingAccountId.IdString == BA.BillingAccountId.IdString);
                FakeData.BillingAccounts[index] = BA;

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}