using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Service;
using NUnit.Framework;

namespace AccountPresentationSystem.Tests.Domain.Service
{
    [TestFixture]
    public class LoadManagerServiceTest
    {
        [Test]
        public void CreateLoadManagerTest()
        {
            // Arrange
            LoadManagerService MyService = new LoadManagerService();

            // Act
            bool retVal = MyService.CreateLoadManager();

            // Assert
            Assert.IsTrue(retVal);
        }
    }
}
