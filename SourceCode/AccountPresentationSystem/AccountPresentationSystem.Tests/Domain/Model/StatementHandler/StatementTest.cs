using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementTest
    {
        [Test]
        public void CreateStatement_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
           Assert.Throws(typeof(ArgumentNullException), ()=> new Statement(null,null,null,null));
        }

        [Test]
        public void CreateStatement_ExpectValid()
        {
            //Arrange
            string localStatementIdString = "STMT01";
            StatementId localStatementId = new StatementId(localStatementIdString);
            
            int localstatementtypeno = 1;
            string localstatementtypename = "Municipalities";
            StatementType localStatementType = new StatementType(localstatementtypeno, localstatementtypename);

            int localstatementAccountnumber = 1234567;
            string localstatementAccountholdername = "Bruce";
            DateTime localstatementDate = DateTime.Now;
            StatementCommonFields localStatementCommonFields = new StatementCommonFields(localstatementAccountnumber, localstatementAccountholdername, localstatementDate);

            string localstatementfieldname1 = "Instalment notice";
            string localstatementfieldvalue1 = "You will need to pay by the 25th on the month";
            StatementSpecificFields localStatementSpecificFields = new StatementSpecificFields(localstatementfieldname1, localstatementfieldvalue1);

            //Act
            Statement localStatement = new Statement(localStatementId, localStatementCommonFields, localStatementType, localStatementSpecificFields);

            //Assert
            Assert.AreEqual(localStatement.StatementId, localStatementId);
            Assert.AreEqual(localStatement.StatementCommonFields, localStatementCommonFields);
            Assert.AreEqual(localStatement.StatementType, localStatementType);
            Assert.AreEqual(localStatement.StatementSpecificFields, localStatementSpecificFields);
        }
    }
}
