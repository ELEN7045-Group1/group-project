using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public interface IScrapeTaskRepository
    {
        void SaveScrapeTask(ScrapeTask task);
        List<ScrapeTask> GetAllScrapeTask();
    }
}
