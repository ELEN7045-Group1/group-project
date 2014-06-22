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

    [TestFixture]
    class BillingAccountRepoTest
    {
        [Test]
        public void Get_BillingAccounts_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IBillingAccountRepository>();

            repository.Expect(r => r.GetAllBillingAccounts());

            repository.GetAllBillingAccounts();

            repository.VerifyAllExpectations();
        }
    }
}
