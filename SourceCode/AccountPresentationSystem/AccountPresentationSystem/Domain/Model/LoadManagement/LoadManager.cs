using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManager : IValueObject<LoadManager>
    {
        public void Start(BillingCompanyInfo billingCompanyInfo)
        {
            // Load all the reules for the LoadManager
            LoadManagerRules loadManagerRules = new LoadManagerRules();
            List<LoadManagerRule> rules = loadManagerRules.LoadRules();

            // Call the scrape session to initialise the scrape
            ScrapeSession scrapeSession = new ScrapeSession();
            scrapeSession.CreateScrapeSession(rules, billingCompanyInfo);
        }

        public bool SameValueAs(LoadManager other)
        {
            return true;
        }
    }
}