using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.Billing;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementTest
    {
        [Test]
        public void CreateStatement_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
           Assert.Throws(typeof(ArgumentNullException), ()=> new Statement(null,null,null,null,null, null));
        }

        [Test]
        public void CreateStatement_ExpectValid()
        {
            //Arrange
            string localStatementIdString = "STMT01";
            StatementId localStatementId = new StatementId(localStatementIdString);

            SpecificFieldsFactory localfactory = new SpecificFieldsFactory();
            string[] listspecificfields = { "Credit Card", "12" };
            StatementType localStatementType = new StatementType(localfactory, "CreditCardProvider", listspecificfields);

            StatementSpecificFields localspecificfields = localStatementType.getSpecificFields();

            
            int localstatementAccountnumber = 1234567;
            string localstatementAccountholdername = "Bruce";
            DateTime localstatementDate = DateTime.Now;
            StatementCommonFields localStatementCommonFields = new StatementCommonFields(localstatementAccountnumber, localstatementAccountholdername, localstatementDate);

            APSUser localAPSUser = new APSUser(new APSUserId("1"), "testusername", "testpassword");
            BillingAccount localBillingAccount = new BillingAccount(new BillingAccountId("1"), new BillingCompanyId("1"), "testusername", "testpassword", localAPSUser);

            //Act
            Statement localStatement = new Statement(localStatementId, localStatementCommonFields, localStatementType, localspecificfields, localAPSUser, localBillingAccount);

            //Assert
            Assert.AreEqual(localStatement.StatementId, localStatementId);
            Assert.AreEqual(localStatement.StatementCommonFields, localStatementCommonFields);
            Assert.AreEqual(localStatement.StatementType, localStatementType);
            Assert.AreEqual(localStatement.StatementSpecificFields, localspecificfields);
            Assert.AreEqual(localStatement.APSUser, localAPSUser);
            Assert.AreEqual(localStatement.BillingAccount, localBillingAccount);
    
        }
    }
}
