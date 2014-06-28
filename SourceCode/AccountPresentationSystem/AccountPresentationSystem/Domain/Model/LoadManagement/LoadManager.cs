using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManager
    {
        public void Start()
        {
            // Load all the reules for the LoadManager
            LoadManagerRules loadManagerRules = new LoadManagerRules();
            List<LoadManagerRule> rules = loadManagerRules.LoadRules();

            // Call the scrape session to initialise the scrape
            ScrapeSession scrapeSession = new ScrapeSession();
            scrapeSession.CreateScrapeSession(rules);
        }
    }
}