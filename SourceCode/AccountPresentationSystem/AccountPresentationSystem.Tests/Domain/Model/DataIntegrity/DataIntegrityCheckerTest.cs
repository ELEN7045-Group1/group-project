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
    public class DataIntegrityCheckerTest
    {
        [Test]
        public void Create_DataIntegrityChecker_ExceptionThrown()
        {
            //Arrange -> Act -> Assert
            Assert.Throws(typeof(ArgumentNullException), () => new DataIntegrityChecker(null));
        }    
    }
}
