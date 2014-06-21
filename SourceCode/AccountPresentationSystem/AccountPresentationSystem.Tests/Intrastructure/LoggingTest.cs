using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Infrastructure;
using NDDDSample.Domain.Shared;
using NUnit.Framework;

namespace AccountPresentationSystem.Tests.Intrastructure
{
    [TestFixture]
    public class LoggingTest
    {
        [Test]
        public void CreateScheduleTest()
        {
            // Arrange
            Logging MyService = new Logging();

            // Act
            bool retVal = MyService.LogMessage(Enumeration.LoggingPriority.Medium, "123456", new Exception()); ;

            // Assert
            Assert.IsTrue(retVal);
        }
    }
}
