using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Model.ErrorHandling;
using AccountPresentationSystem.Domain.Shared;
using AccountPresentationSystem.Infrastructure;
using AccountPresentationSystem.Interface;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class ScrapeSession : IEntity<ScrapeSession>
    {
        private readonly ScrapeSession _scrapeSession;

        public void CreateScrapeSession(List<LoadManagerRule> rules, BillingCompanyInfo billingCompanyInfo)
        {
            Logging log = new Logging();
            ReferenceGenerator refGen = new ReferenceGenerator();
            string refNum = refGen.GenerateReference();

            try
            {
                // Get scraping scripts per billing company
                log.LogMessage(Enumeration.LoggingPriority.Low, refNum, "Get scraping scripts per billing company");
                BillingCompany getScrapingScripts = new BillingCompany(new BillingCompanyId(billingCompanyInfo.BillingCompanyId), billingCompanyInfo.BillingCompanyName);
                List<ScrapingScript> scrapingScripts = getScrapingScripts.GetScrapingScripts();


                foreach (var scrapingScript in scrapingScripts)
                {
                    // Process errors
                    if (scrapingScript.ErrorCode == 91)
                    {
                        BrokenScript brokenScript = new BrokenScript(Enumeration.ErrorCode.BrokenScript, scrapingScript.ScriptSiteURL, DateTime.Now);
                    }   
                }

                // Call the 3rd party provider to perform the scrape
                log.LogMessage(Enumeration.LoggingPriority.Low, refNum, "Call the 3rd party provider to perform the scrape");
                ScraperProvider scraperProvider = new ScraperProvider();
                List<ScrapeData> scrapeData = scraperProvider.RequestScrape();

                foreach (var data in scrapeData)
                {
                    // Process errors
                    if (data.ErrorCode == 91)
                    {
                        BillingCompanySiteDown siteDown = new BillingCompanySiteDown(Enumeration.ErrorCode.BillingCompanySiteDown, "", DateTime.Now);
                    }
                    else if (data.ErrorCode == 92)
                    {
                        CustomerActionRequired custActionReq = new CustomerActionRequired(Enumeration.ErrorCode.CustomerActionRequired, "", DateTime.Now);
                    }
                    else if (data.ErrorCode == 93)
                    {
                        IncorrectAccount incorrectAcc = new IncorrectAccount(Enumeration.ErrorCode.IncorrectAccount, "", DateTime.Now);
                    }
                    else if (data.ErrorCode == 94)
                    {
                        InvalidCredentials invalidCredentials = new InvalidCredentials(Enumeration.ErrorCode.InvalidCredentials, "", DateTime.Now);
                    }
                }

                // Save scraped data to the Repo
                log.LogMessage(Enumeration.LoggingPriority.Low, refNum, "Save scraped data to the Repo");
                ScrapeDataRepository scrapeDataRepo = new ScrapeDataRepository();
                List<LoadManagerErrors> saveErrors = scrapeDataRepo.SaveScrapeData(scrapeData);

                foreach (var saveError in saveErrors)
                {
                    // Process errors
                    if (saveError.ErrorCode == 91)
                    {
                        UnableToCheckDataIntegrity unableToCheckDataIntegrity = new UnableToCheckDataIntegrity(Enumeration.ErrorCode.UnableToCheckDataIntegrity, saveError.Message, DateTime.Now);
                    }
                        
                }

            }
            catch (Exception ex)
            {
                // Process errors

                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);
            }  
        }

        public bool SameValueAs(ScrapeSession other)
        {
            return true;
        }

        public ScrapeSession scrapeSession
        {
            get { return _scrapeSession; }
        }

        public virtual bool SameIdentityAs(ScrapeSession other)
        {
            return scrapeSession.SameValueAs(other.scrapeSession);
        }
    }
}