using System;
using System.Collections.Generic;
namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public interface IScrapeDataRepository
    {
        List<LoadManagerErrors> SaveScrapeData(List<ScrapeData> scrapedData);
    }
}
