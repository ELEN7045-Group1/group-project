﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Infrastructure;
using AccountPresentationSystem.Domain.Shared;
using NUnit.Framework;

namespace AccountPresentationSystem.Tests.Intrastructure
{
    [TestFixture]
    public class LoggingTest
    {
        [Test]
        public void CreateLoggingTest()
        {
            Logging MyService = new Logging();

            bool retVal = MyService.LogMessage(Enumeration.LoggingPriority.Medium, "123456", new Exception()); ;

            Assert.IsTrue(retVal);
        }
    }
}
