using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.LoadManagement;

namespace AccountPresentationSystem.Interface
{
    public class ScraperProvider
    {
        // Where the mapping will be between the APS and the 3rd party scraper
        public List<ScrapeData> RequestScrape()
        {
            // Will return the data that was scraped on the website
            return new List<ScrapeData>();
        }
    }
}