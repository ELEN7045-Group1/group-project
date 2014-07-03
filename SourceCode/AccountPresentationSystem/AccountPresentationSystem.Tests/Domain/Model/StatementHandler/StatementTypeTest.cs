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
        public void CreateStatementSpecificFields_ExpectValid()
        {
            //Arrange
            SpecificFieldsFactory localfactory = new SpecificFieldsFactory();

            string[] listspecificfields = { "You will need to pay by the 25th on the month", "1000" };

            StatementType localStatementType = new StatementType(localfactory, "Municipality", listspecificfields);
            
            StatementSpecificFields localspecificfields = localStatementType.getSpecificFields();

            //Assert
            Assert.IsNotNull(localspecificfields);
            
        }
    }
}
