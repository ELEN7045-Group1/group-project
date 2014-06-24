namespace AccountPresentationSystem.Tests.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Model.DataIntegrity;
    using NUnit.Framework;
    using Rhino.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class DataIntegrityRuleRepoTest
    {
        [Test]
        public void GetStandardDataIntegrityRules_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IDataIntegrityRuleRepository>();

            repository.Expect(r => r.GetStandardIntegrityRules());

            repository.GetStandardIntegrityRules();

            repository.VerifyAllExpectations();
        }

        [Test]
        public void GetCustomDataIntegrityRules_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IDataIntegrityRuleRepository>();

            repository.Expect(r => r.GetCustomIntegrityRules());

            repository.GetCustomIntegrityRules();

            repository.VerifyAllExpectations();
        }

        [Test]
        public void GetDataIntegrityRules_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IDataIntegrityRuleRepository>();

            repository.Expect(r => r.GetAllIntegrityRules());

            repository.GetAllIntegrityRules();

            repository.VerifyAllExpectations();
        }
    }
}
