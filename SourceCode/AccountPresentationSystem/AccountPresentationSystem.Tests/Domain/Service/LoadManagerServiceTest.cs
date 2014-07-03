using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Model.LoadManagement;
using AccountPresentationSystem.Domain.Service;
using NUnit.Framework;

namespace AccountPresentationSystem.Tests.Domain.Service
{
    [TestFixture]
    public class LoadManagerServiceTest
    {
        [Test]
        public void CreateLoadManagerTest(BillingCompanyInfo billingCompanyInfo)
        {
            LoadManagerService MyService = new LoadManagerService();

            bool retVal = MyService.CreateLoadManager(billingCompanyInfo);

            Assert.IsTrue(retVal);
        }
    }
}
