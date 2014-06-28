using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Interface;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class ScrapeSession
    {
        public void CreateScrapeSession(List<LoadManagerRule> rules)
        {
            try
            {
                // Get scraping scripts per billing company
                //BillingCompany getScrapingScripts = new BillingCompany();
                //List<ScrapingScript> scrapingScripts = getScrapingScripts();

                //foreach (var scrapingScript in scrapingScripts)
                //{
                //    if(scrapingScript.ErrorCode == 91)
                //        // Process errors
                //}

                // Call the 3rd party provider to perform the scrape
                ScraperProvider scraperProvider = new ScraperProvider();
                List<ScrapeData> scrapeData = scraperProvider.RequestScrape();

                //foreach (var data in scrapeData)
                //{
                //    if(data.ErrorCode == 91)
                //        // Process errors
                //}

                // Save scraped data to the Repo
                ScrapeDataRepository scrapeDataRepo = new ScrapeDataRepository();
                List<LoadManagerErrors> saveErrors = scrapeDataRepo.SaveScrapeData(scrapeData);

                //foreach (var saveError in saveErrors)
                //{
                //    if(saveError.ErrorCode == 91)
                //        // Process errors
                //}

            }
            catch(Exception ex)
            {
                // Process errors
            }    
        }
    }
}