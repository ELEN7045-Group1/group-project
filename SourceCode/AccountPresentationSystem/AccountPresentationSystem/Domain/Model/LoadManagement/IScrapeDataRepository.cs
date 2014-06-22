using System;
namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    interface IScrapeDataRepository
    {
        bool SaveScrapeData(System.Collections.Generic.IList<ScrapeData> scrapedData);
    }
}
