namespace AccountPresentationSystem.Tests.Domain.Model.APSUser
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
    class APSUserTest
    {
        [Test]
        public void Create_NewAPSUser_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new APSUser(null, null,null));
        }

        [Test]
        public void Create_NewAPSUSer_ExpectValid()
        {
            //Arrange
            string localAPSUserIdString = "APS01";
            string localUsername = "John";
            string localPassword = "John123";
            APSUserId localAPSUserId = new APSUserId(localAPSUserIdString);

            //Act
            APSUser localAPSUser = new APSUser(localAPSUserId, localUsername, localPassword);

            //Assert
            Assert.AreEqual(localAPSUser.APSUserId, localAPSUserId);
            Assert.AreEqual(localAPSUser.APSUsername, localUsername);
            Assert.AreEqual(localAPSUser.APSPassword, localPassword);
        }

        [Test]
        public void Add_BillingAccount_ExpectAccountAdded()
        {
            //Arrange
            string localAPSUserIdString = "APS01";
            string localUsername = "John";
            string localPassword = "John123";
            APSUserId localAPSUserId = new APSUserId(localAPSUserIdString);
            APSUser localAPSUser = new APSUser(localAPSUserId, localUsername, localPassword);

            string localBillingAccountIdString = "APSBA01";
            string localBillingCompanyIdString = "COJ01";
            string localBillingAccountUsername = "Billy";
            string localBillingAccountPassword = "Billy123";
            BillingAccountId localBillingAccountId = new BillingAccountId(localBillingAccountIdString);
            BillingCompanyId localBillingCompanyId = new BillingCompanyId(localBillingCompanyIdString);
            BillingAccount localBillingAccount = new BillingAccount(localBillingAccountId,
               localBillingCompanyId, localBillingAccountUsername, localBillingAccountPassword, localAPSUser);

            //Act
            localAPSUser.AddBillingAccount(localBillingAccount);

            //Assert
            Assert.AreEqual(localAPSUser.BillingAccounts.First(ba => ba.BillingAccountId == localBillingAccountId),localBillingAccount);
        }
    }
}
