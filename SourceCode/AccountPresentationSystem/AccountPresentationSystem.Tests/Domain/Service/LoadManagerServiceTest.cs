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
            LoadManagerService MyService = new LoadManagerService();

            bool retVal = MyService.CreateLoadManager();

            Assert.IsTrue(retVal);
        }
    }
}
