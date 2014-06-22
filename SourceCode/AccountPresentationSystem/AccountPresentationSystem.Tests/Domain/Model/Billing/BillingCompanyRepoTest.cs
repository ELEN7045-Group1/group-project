namespace AccountPresentationSystem.Tests.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Model.Billing;
    using NUnit.Framework;
    using Rhino.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Transactions;

    [TestFixture]
    class BillingCompanyRepoTest
    {
        [Test]
        public void Get_BillingCompanies_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IBillingCompanyRepository>();

            repository.Expect(r => r.GetAllBillingCompanies());

            repository.GetAllBillingCompanies();

            repository.VerifyAllExpectations();
        }
    }
}
