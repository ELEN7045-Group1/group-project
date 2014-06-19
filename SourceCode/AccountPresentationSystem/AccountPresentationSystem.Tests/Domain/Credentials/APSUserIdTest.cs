namespace AccountPresentationSystem.Tests.Domain.Credentials
{
    using AccountPresentationSystem.Domain.Credentials;
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
            //APSUserId localAPSUserId = new APSUserId(null);

            Assert.Throws(typeof(ArgumentNullException), ()=> new APSUserId(null));
        }
    }
}
