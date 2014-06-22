using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Model.LoadManagement;
using NUnit.Framework;

namespace AccountPresentationSystem.Tests.Domain.Model.LoadManagement
{
    [TestFixture]
    public class LoadManagerTest
    {
        [Test]
        public void CreateLoadManagerTest()
        {
            ScrapeDataRepository MyService = new ScrapeDataRepository();

            bool retVal = MyService.SaveScrapeData(new List<ScrapeData>
            {
                
            });

            Assert.IsTrue(retVal);
        }
    }
}
