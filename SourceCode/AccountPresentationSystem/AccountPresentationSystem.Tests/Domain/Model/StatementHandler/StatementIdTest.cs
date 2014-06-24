using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementIdTest
    {
        [Test]
        public void CreateStatementId_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new Statement(null, null, null, null));
        }

        [Test]
        public void CreateStatementId_ExpectValid()
        {
            //Arrange
            string localStatementIdString = "STMT01";

            //Act
            StatementId localStatementId = new StatementId(localStatementIdString);

            //Assert
            Assert.AreEqual(localStatementId.StatementIdString, localStatementIdString);
        }
    }
}
