using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementSpecificFieldsTest
    {
        [Test]
        public void CreateStatementSpecificFields_ExpectValid()
        {
            //Arrange
            string localstatementfieldname1 = "Card Type";
            string localstatementfieldvalue1 = "Credit Card";
            
            //Act
            StatementSpecificFields localStatementSpecificFields = new StatementSpecificFields(localstatementfieldname1, localstatementfieldvalue1);

            //Assert
            Assert.AreEqual(localStatementSpecificFields.StatementFieldName1, localstatementfieldname1);
            Assert.AreEqual(localStatementSpecificFields.StatementFieldValue1, localstatementfieldvalue1);
            
        }
    }
}
