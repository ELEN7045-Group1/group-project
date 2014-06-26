namespace AccountPresentationSystem.Tests.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Model.Billing;
    using AccountPresentationSystem.Domain.Model.APSUser;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class BillingAccountTest
    {
        [Test]
        public void Create_BillingAccount_ExceptionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new BillingAccount(null, null, null, null, null));
        }

        [Test]
        public void Create_BillingAccount_ExpectValid()
        {
            //Arrange
            string localBillingAccountIdString = "APSBA01";
            string localBillingCompanyIdString = "COJ01";
            string localBillingAccountUsername = "Billy";
            string localBillingAccountPassword = "Billy123";
            BillingAccountId localBillingAccountId = new BillingAccountId(localBillingAccountIdString);
            BillingCompanyId localBillingCompanyId = new BillingCompanyId(localBillingCompanyIdString);
            APSUser localAPSUser = new APSUser(new APSUserId("1"), "testuser", "testPasssword");

            //Act
            BillingAccount localBillingAccount = new BillingAccount(localBillingAccountId,
                localBillingCompanyId, localBillingAccountUsername, localBillingAccountPassword, localAPSUser);
            
            //Assert
            Assert.AreEqual(localBillingAccount.BillingAccountId, localBillingAccountId);
            Assert.AreEqual(localBillingAccount.BillingCompanyId, localBillingCompanyId);
            Assert.AreEqual(localBillingAccount.BillingAccountUsername, localBillingAccountUsername);
            Assert.AreEqual(localBillingAccount.BillingAccountPassword, localBillingAccountPassword);
        }
    }
}
