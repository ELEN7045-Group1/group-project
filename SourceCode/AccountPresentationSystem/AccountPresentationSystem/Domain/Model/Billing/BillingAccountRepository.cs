namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Model.APSUser;
    using AccountPresentationSystem.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    public class BillingAccountRepository : IBillingAccountRepository
    {
        IDBConnection dataConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCompanyRepository"/> class.
        /// </summary>
        /// <param name="DBConnection">The database connection.</param>
        public BillingAccountRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        /// <summary>
        /// Gets all billing accounts.
        /// </summary>
        /// <returns></returns>
        public List<BillingAccount> GetAllBillingAccounts()
        {
            List<BillingAccount> billingAccounts = new List<BillingAccount>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve All Billing Accounts");

            foreach (DataRow dr in dt.Rows)
            {
                billingAccounts.Add(new BillingAccount((BillingAccountId)dr["billingAccountId"],
                    (BillingCompanyId)dr["billingCompanyId"], (string)dr["billingAccountUsername"],
                    (string)dr["billingAccountPassword"], new APSUser(new APSUserId("1"), "username1", "password1")));
            }

            return billingAccounts;
        }
    }
}