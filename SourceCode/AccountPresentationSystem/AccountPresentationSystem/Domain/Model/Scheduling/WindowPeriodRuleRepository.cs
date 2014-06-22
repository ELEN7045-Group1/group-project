using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class WindowPeriodRuleRepository
    {
        private readonly IDBConnection dataConnection;

        public WindowPeriodRuleRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        public List<WindowPeriodRule> GetAllWindowPeriodRulesPerBillingCompany(BillingCompany billingCompany)
        {
            // This returns all Window Period rules for a specific billing company

            string BillingCompanyID = billingCompany.billingCompanyId.IdString;

            List<WindowPeriodRule> ReturnList = new List<WindowPeriodRule>();
            return ReturnList;
        }
    }
}