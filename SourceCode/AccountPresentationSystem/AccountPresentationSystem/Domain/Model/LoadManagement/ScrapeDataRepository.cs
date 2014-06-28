using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Infrastructure;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class ScrapeDataRepository : IScrapeDataRepository
    {
        IDBConnection dataConnection;

        public ScrapeDataRepository()
        {
            //this.dataConnection = DBConnection;
        }

        public List<LoadManagerErrors> SaveScrapeData(List<ScrapeData> scrapedData)
        {
            List<LoadManagerErrors> loadManagerErrors = new List<LoadManagerErrors>();
            Logging log = new Logging();
            int rowsSavedCount = 0;

            try
            {
                foreach (ScrapeData data in scrapedData)
                {
                    int dataSaved = dataConnection.ExecuteStatement("Insert each scraped row of data in the DB");
                    rowsSavedCount = rowsSavedCount + dataSaved;
                }

                log.LogMessage(Enumeration.LoggingPriority.Low, "123", rowsSavedCount.ToString() + " scraped data rows stored in DB");

                loadManagerErrors.Add(new LoadManagerErrors { ErrorCode = 00, ErrorDescription = "Scraped Data Saved", Message = rowsSavedCount.ToString() + " records saved" });
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, "123", ex);

                loadManagerErrors.Add(new LoadManagerErrors { ErrorCode = 91, ErrorDescription = "Error Occured", Message = ex.InnerException.Message });
            }

            return loadManagerErrors;
        }
    }
}