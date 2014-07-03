using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rhino.Mocks;
using AccountPresentationSystem.Infrastructure;
using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.Billing;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    [TestFixture]
    public class ScheduleTest
    {
        IDBConnection db;
        IScrapeTaskRepository taskRepo;
        IBillingAccountRepository billingAccountRepo;
        IScrapeTaskFactory scrapeTaskFactory;

        [SetUp]
        public void SetupTests()
        {
            db = MockRepository.GenerateMock<IDBConnection>();
            taskRepo = MockRepository.GenerateMock<ScrapeTaskRepository>(db);
            billingAccountRepo = MockRepository.GenerateMock<BillingAccountRepository>(db);
            scrapeTaskFactory = MockRepository.GenerateMock<ScrapeTaskFactory>();
        }


        [Test]
        public void RunCreateNewTaskTest()
        {
            // Arrange
            Schedule MySchedule = new Schedule(taskRepo, billingAccountRepo, scrapeTaskFactory);

            // Act
            int TasksCreatedCount = MySchedule.CreateNewTasks();

            // Assert
            Assert.IsTrue(TasksCreatedCount >= 0);
        }

        [Test]
        public void DetectNewBillingAccountTaskTest()
        {
            // Arrange
            APSUser.APSUser user = new APSUser.APSUser(new APSUserId(Guid.NewGuid().ToString()), "usenrame1", "password1");
            BillingCompany billingCompany = new BillingCompany(new BillingCompanyId(Guid.NewGuid().ToString()), "PVC Test Company");
            BillingAccount billingAccount = new BillingAccount(new BillingAccountId(Guid.NewGuid().ToString()), billingCompany.billingCompanyId, "username1", "password1", user);

            Schedule MySchedule = new Schedule(taskRepo, billingAccountRepo, scrapeTaskFactory);

            // Act
            int TasksCreatedCount = MySchedule.CreateNewTasks();

            // Assert
            Assert.IsTrue(TasksCreatedCount == 1);
        }

    }
}