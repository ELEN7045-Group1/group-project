using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Scheduling;

namespace AccountPresentationSystem.Domain.Schedule
{
    [TestFixture]
    public class SchedulerServiceTest
    {
        [Test]
        public void CreateScheduleTest()
        {
            // Arrange
            SchedulerService MyService = new SchedulerService();

            // Act
            bool retVal = MyService.CreateSchedule();

            // Assert
            Assert.IsTrue(retVal);
        }
    }
}