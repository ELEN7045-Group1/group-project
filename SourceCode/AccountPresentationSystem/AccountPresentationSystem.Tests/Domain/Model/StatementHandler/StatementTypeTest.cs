using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementTypeTest
    {
        [Test]
        public void CreateStatementType_ExpectValid()
        {
            //Arrange
            int localstatementtypeno = 2;
            string localstatementtypename = "Credit Card Providers";
            
            
            //Act
            StatementType localStatementType = new StatementType(localstatementtypeno, localstatementtypename);

            //Assert
            Assert.AreEqual(localStatementType.StatementTypeNo, localstatementtypeno);
            Assert.AreEqual(localStatementType.StatementTypeName, localstatementtypename);
            
        }
    }
}
