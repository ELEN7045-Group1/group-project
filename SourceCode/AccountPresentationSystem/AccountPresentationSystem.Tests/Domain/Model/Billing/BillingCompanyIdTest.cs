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
    class BillingCompanyIdTest
    {
        [Test]
        public void Create_BillingCompanyId_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new BillingCompanyId(null));
        }

        [Test]
        public void Create_BillingCompanyId_ExpectValidId()
        {
            //Arrange
            string localId = "abc123";

            //Act
            BillingCompanyId localBillingCompanyId = new BillingCompanyId(localId);

            //Assert
            Assert.AreEqual(localBillingCompanyId.IdString, localId);
        }

        [Test]
         public void Compare_BillingCompanyId_ExpectObjectImmutability()
        {
            //Arrange
            string localId1 = "abc123";
            string localId2 = "abc123";

            //Act
            BillingCompanyId localBillingCompanyId1 = new BillingCompanyId(localId1);
            BillingCompanyId localBillingCompanyId2 = new BillingCompanyId(localId2);

             //Assert
            Assert.IsTrue(localBillingCompanyId1.SameValueAs(localBillingCompanyId2));
        }
    }
}
