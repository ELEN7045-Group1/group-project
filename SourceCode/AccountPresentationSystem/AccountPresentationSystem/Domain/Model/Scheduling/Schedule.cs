using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class Schedule : IEntity<Schedule>, ISchedule
    {
        private readonly IScrapeTaskRepository taskRepo;
        private readonly IBillingAccountRepository billingAccountRepo;
        private readonly IScrapeTaskFactory scrapeTaskFactory;

        public Schedule(IScrapeTaskRepository _taskRepo, IBillingAccountRepository _billingAccountRepo, IScrapeTaskFactory _scrapeTaskFactory)
        {
            taskRepo = _taskRepo;
            billingAccountRepo = _billingAccountRepo;
            scrapeTaskFactory = _scrapeTaskFactory;
        }

        public int CreateNewTasks()
        {
            // This retrieves all billing accounts with no scrape tasks and create new tasks for them
            List<BillingAccount> AllAcounts = billingAccountRepo.GetAllBillingAccountsWithNoScrapeTasks();

            Parallel.ForEach<BillingAccount>(AllAcounts, billingAccount =>
            {
                CreateTask(billingAccount);
            });

            return AllAcounts.Count;
        }

        private void CreateTask(BillingAccount billingAccount)
        {
            // This creates a new task based on the billing account, and then stores into the task repo
            ScrapeTask newTask = scrapeTaskFactory.NewScrapeTask(billingAccount);
            taskRepo.SaveScrapeTask(newTask);
        }

        public bool SameIdentityAs(Schedule other)
        {
            throw new NotImplementedException();
        }
    }

    
}