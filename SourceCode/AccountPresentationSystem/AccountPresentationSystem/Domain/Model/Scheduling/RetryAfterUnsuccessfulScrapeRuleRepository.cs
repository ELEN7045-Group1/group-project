using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class RetryAfterUnsuccessfulScrapeRuleRepository
    {
        private readonly IDBConnection dataConnection;

        public RetryAfterUnsuccessfulScrapeRuleRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        public List<RetryAfterUnsuccessfulScrapeRule> GetAllRetryAfterUnsuccessfulScrapeRulesPerBillingCompany(BillingCompany billingCompany)
        {
            // This returns all RetryAfterUnsuccessful rules for a specific billing company

            string BillingCompanyID = billingCompany.billingCompanyId.IdString;

            List<RetryAfterUnsuccessfulScrapeRule> ReturnList = new List<RetryAfterUnsuccessfulScrapeRule>();
            return ReturnList;
        }
    }
}