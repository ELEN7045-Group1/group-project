namespace AccountPresentationSystem.Tests.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Model.APSUser;
    using AccountPresentationSystem.Domain.Model.Billing;
    using AccountPresentationSystem.Domain.Model.DataIntegrity;
    using AccountPresentationSystem.Domain.Model.StatementHandler;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class DataIntegrityRuleTest
    {
        [Test]
        public void AdditionRuleIntegrityCheckTest()
        {
            //Arrange
                    StatementId _statementId;
        StatementCommonFields _statementCommonFields;
        StatementType _statementType;
        List<StatementSpecificFields> _statementSpecificFields;
        APSUser _apsuser;
        BillingAccount _billingAccount;

            //Statement _statement = new Statement(_statementId, _statementCommonFields, _statementType, _statementSpecificFields, _apsuser, _billingAccount);
            DataIntegrityRule dir = new DataIntegrityRule();

            //Act
            bool result = dir.PerformAdditionCheck();

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void VATRuleIntegrityCheckTest()
        {
            //Arrange
            DataIntegrityRule dir = new DataIntegrityRule();

            //Act
            bool result = dir.PerformVATCheck();

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DuplicateRuleIntegrityCheckTest()
        {
            //Arrange
            DataIntegrityRule dir = new DataIntegrityRule();

            //Act
            bool result = dir.PerformDuplicateCheck();

            //Assert
            Assert.IsTrue(result);
        }
    }
}
