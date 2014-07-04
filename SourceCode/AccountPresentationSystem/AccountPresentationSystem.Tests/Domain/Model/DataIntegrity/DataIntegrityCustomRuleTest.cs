namespace AccountPresentationSystem.Tests.Domain.Model.DataIntegrity
{
    using AccountPresentationSystem.Domain.Model.DataIntegrity;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class DataIntegrityCustomRuleTest
    {
        [Test]
        public void Create_DataIntegrityCustomRule_ExceptionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new DataIntegrityCustomRule(null));
        }
    }
}
