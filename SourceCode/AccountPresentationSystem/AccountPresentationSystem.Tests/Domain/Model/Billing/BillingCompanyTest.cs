namespace AccountPresentationSystem.Tests.Domain.Billing
{
    using AccountPresentationSystem.Domain.Billing;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class BillingCompanyTest
    {
        [Test]
        public void Create_BillingCompany_ExceptionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new BillingCompany(null,null));
        }

        [Test]
        public void Create_BillingCompany_ExpectValidCompany()
        {
            //Arrange
            string billingCompanyIdString = "CoJ01";
            string billingCompanyName = "City of Johannesburg";
            BillingCompanyId billingCompanyId = new BillingCompanyId(billingCompanyIdString);

            //Act
            BillingCompany billingCompany = new BillingCompany(billingCompanyId, billingCompanyName);

            //Assert
            Assert.AreEqual(billingCompanyId, billingCompany.billingCompanyId);
            Assert.AreEqual(billingCompanyName, billingCompany.CompanyName);

        }
    }
}
