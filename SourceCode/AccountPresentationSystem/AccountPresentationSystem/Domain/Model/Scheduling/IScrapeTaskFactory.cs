using AccountPresentationSystem.Domain.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public interface IScrapeTaskFactory
    {
        ScrapeTask NewScrapeTask(BillingAccount billingAccount);
    }
}
