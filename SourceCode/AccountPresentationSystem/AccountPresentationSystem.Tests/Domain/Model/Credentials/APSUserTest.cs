namespace AccountPresentationSystem.Tests.Domain.Model.Credentials
{
    using AccountPresentationSystem.Domain.Model.Credentials;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class APSUserTest
    {
        [Test]
        public void Create_NewAPSUser_ExpectionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new APSUser(null, null,null));
        }

        [Test]
        public void Create_NewAPSUSer_ExpectValid()
        {
            //Arrange
            string localAPSUserIdString = "APS01";
            string localUsername = "John";
            string localPassword = "John123";
            APSUserId localAPSUserId = new APSUserId(localAPSUserIdString);

            //Act
            APSUser localAPSUser = new APSUser(localAPSUserId, localUsername, localPassword);

            //Assert
            Assert.AreEqual(localAPSUser.APSUserId, localAPSUserId);
            Assert.AreEqual(localAPSUser.APSUsername, localUsername);
            Assert.AreEqual(localAPSUser.APSPassword, localPassword);
        }
    }
}
