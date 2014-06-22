namespace AccountPresentationSystem.Tests.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Model.Billing;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class BillingAccountIdTest
    {
        [Test]
        public void Create_BillingAccountId_ExpectExceptionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new BillingAccountId(null));
        }

        [Test]
        public void Create_BillingAccountId_ExpectValidId()
        {
            //Arrange
            string localId = "abc123";

            //Act
            BillingAccountId localBillingAccountId = new BillingAccountId(localId);

            //Assert
            Assert.AreEqual(localBillingAccountId.IdString, localId);
        }

        [Test]
        public void Compare_BillingAccountId_ExpectObjectImmutability()
        {
            //Arrange
            string localId1 = "abc123";
            string localId2 = "abc123";

            //Act
            BillingAccountId localBillingAccountId1 = new BillingAccountId(localId1);
            BillingAccountId localBillingAccountId2 = new BillingAccountId(localId2);

            //Assert
            Assert.AreEqual(localBillingAccountId1.IdString, localBillingAccountId2.IdString);
        }


    }
}
