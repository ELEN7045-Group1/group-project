using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManager : IValueObject<LoadManager>
    {
        public bool Start(BillingCompanyInfo billingCompanyInfo)
        {
            bool result = false;
            Logging log = new Logging();
            ReferenceGenerator refGen = new ReferenceGenerator();
            string refNum = refGen.GenerateReference();

            try
            {
                // Load all the rules for the LoadManager
                LoadManagerRules loadManagerRules = new LoadManagerRules();
                List<LoadManagerRule> rules = loadManagerRules.LoadRules();

                // Call the scrape session to initialise the scrape
                ScrapeSession scrapeSession = new ScrapeSession();
                scrapeSession.CreateScrapeSession(rules, billingCompanyInfo);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);
            }

            return result;
        }

        public bool SameValueAs(LoadManager other)
        {
            return true;
        }
    }
}