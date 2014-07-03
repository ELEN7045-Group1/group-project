using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class Schedule : IValueObject<Schedule>
    {
        private readonly ITaskRepository taskRepo;
        private readonly IBillingCompanyRepository billingCompanyRepo;

        public Schedule(ITaskRepository _taskRepo, IBillingCompanyRepository _billingCompanyRepo)
        {
            taskRepo = _taskRepo;
            billingCompanyRepo = _billingCompanyRepo;
        }

        public int CreateNewTasks()
        {

            return 0;
        }

        public bool SameValueAs(Schedule other)
        {
            if ((other != null) && (other == this))
                return true;
            else
                return false;
        }
    }

    
}