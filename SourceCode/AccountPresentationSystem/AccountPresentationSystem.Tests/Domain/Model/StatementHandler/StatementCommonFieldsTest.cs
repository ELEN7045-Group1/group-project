using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementCommonFieldsTest
    {
        [Test]
        public void CreateStatement_ExpectValid()
        {
            //Arrange
            int localstatementAccountnumber = 4646687;
            string localstatementAccountholdername = "Peter";
            DateTime localstatementDate = DateTime.Now;
            
            //Act
            StatementCommonFields localStatementCommonFields = new StatementCommonFields(localstatementAccountnumber, localstatementAccountholdername, localstatementDate);

            //Assert
            Assert.AreEqual(localStatementCommonFields.StatementAccountNumber, localstatementAccountnumber);
            Assert.AreEqual(localStatementCommonFields.StatementAccountHolderName, localstatementAccountholdername);
            Assert.AreEqual(localStatementCommonFields.StatementDate, localstatementDate);
            
        }
    }
}
