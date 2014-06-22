namespace AccountPresentationSystem.Tests.Domain.Model.APSUser
{
    using AccountPresentationSystem.Domain.Model.APSUser;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    [TestFixture]
    class APSUserIdTest
    {
        [Test]
        public void  Create_APSUserId_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
           Assert.Throws(typeof(ArgumentNullException), ()=> new APSUserId(null));
        }

        [Test]
        public void Create_APSUserId_ExpectValidId()
        {
            //Arrange
            string localId = "abc123";
            
            //Act
            APSUserId localAPSUserId = new APSUserId(localId);
 
            //Assert
            Assert.AreEqual(localAPSUserId.IdString, localId);
        }

        [Test]
        public void Compare_APSUserId_ExpectObjectImmutability()
        {
            //Arrange
            string localId1 = "abc123";
            string localId2 = "abc123";

            //Act
            APSUserId localAPSUserId1 = new APSUserId(localId1);
            APSUserId localAPSUserId2 = new APSUserId(localId2);

            //Assert
            Assert.AreEqual(localAPSUserId1.IdString, localAPSUserId2.IdString);
        }
    }
}
