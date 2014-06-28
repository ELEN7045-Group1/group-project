using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Model.LoadManagement;
using NUnit.Framework;
using Rhino.Mocks;

namespace AccountPresentationSystem.Tests.Domain.Model.LoadManagement
{
    [TestFixture]
    class ScrapeDataRepoTest
    {
        [Test]
        public void SaveScrapedData()
        {
            var repository = MockRepository.GenerateMock<IScrapeDataRepository>();
            int recordsSaved = repository.SaveScrapeData(new List<ScrapeData>()).Count;

            Assert.True(recordsSaved>0);

            repository.Expect(r => r.SaveScrapeData(new List<ScrapeData>()));

            repository.SaveScrapeData(new List<ScrapeData>());

            repository.VerifyAllExpectations();
        }
    }
}
