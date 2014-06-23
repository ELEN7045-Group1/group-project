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
        public void Get_DataIntegrityRules_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IDataIntegrityRuleRepository>();

            repository.Expect(r => r.GetAllIntegrityRules());

            repository.GetAllIntegrityRules();

            repository.VerifyAllExpectations();
        }
    }
}
