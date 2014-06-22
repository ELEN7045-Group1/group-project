using System;
using System.Collections.Generic;
namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    interface IScrapeDataRepository
    {
        bool SaveScrapeData(List<ScrapeData> scrapedData);
    }
}
