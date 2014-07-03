using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.LoadManagement;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Service
{
    public class LoadManagerService
    {
        private Logging log = new Logging();
        public string refNum = "";

        public bool CreateLoadManager(BillingCompanyInfo billingCompanyInfo)
        {
            ReferenceGenerator refNumber = new ReferenceGenerator();
            string refNum = refNumber.GenerateReference();

            LoadManager loadManager = new LoadManager();
            loadManager.Start(billingCompanyInfo);

            return true;
        }
    }
}