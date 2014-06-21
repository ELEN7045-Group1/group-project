using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.StatementHandler;

namespace AccountPresentationSystem.Tests.Domain.StatementHandler
{
    [TestFixture]
    class StatementTest
    {
        [Test]
        public void CreateStatement_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
           Assert.Throws(typeof(ArgumentNullException), ()=> new Statement(null));
        }
    }
}
