using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Tests.Controllers
{
    [TestFixture]
    public class pvvcControllerTest
    {
        [Test]
        public void GetUsersTest()
        {
            // Arrange
            double Val1 = 5;
            double Val2 = 10;
            pvvcController testController = new pvvcController();

            // Act
            double Result = testController.Addition(Val1, Val2);

            // Assert
            Assert.IsTrue(Result == Val1 + Val2);
        }
    }
}
