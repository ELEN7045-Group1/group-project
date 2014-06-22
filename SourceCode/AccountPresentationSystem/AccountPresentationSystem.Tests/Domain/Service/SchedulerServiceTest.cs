using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.Scheduling;
using AccountPresentationSystem.Domain.Service;
using Rhino.Mocks;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Schedule
{
    [TestFixture]
    public class SchedulerServiceTest
    {
        [Test]
        public void CreateScheduleTest()
        {
            // Arrange
            var db = MockRepository.GenerateMock<IDBConnection>();
            var SchedRepo = MockRepository.GenerateMock<ScheduleRepository>(db);

            SchedulerCreatorService MyService = new SchedulerCreatorService(SchedRepo);

            // Act
            bool retVal = MyService.CreateSchedule();

            // Assert
            Assert.IsTrue(retVal);
        }
    }
}