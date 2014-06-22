namespace AccountPresentationSystem.Tests.Domain.Model.APSUser
{
    using AccountPresentationSystem.Domain.Model.APSUser;
    using NUnit.Framework;
    using Rhino.Mocks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class APSUserRepoTest
    {
        [Test]
        public void Get_APSUsers_ExpectRepoMethodCalled()
        {
            var repository = MockRepository.GenerateMock<IAPSUserRepository>();

            repository.Expect(r => r.GetAllAPSUsers());

            repository.GetAllAPSUsers();

            repository.VerifyAllExpectations();
        }

        [Test]
        public void Get_APSUser_ExpectCorrectUserReturned()
        {
            var repository = MockRepository.GenerateMock<IAPSUserRepository>();
            string localAPSUserIdString = "APS01";
            string localAPSUserName = "Steve";
            string localAPSPassword = "abc123";
            APSUserId localAPSUserId = new APSUserId(localAPSUserIdString);
            APSUser localAPSUser = new APSUser(localAPSUserId,localAPSUserName,localAPSPassword);

            var temp = repository.Stub(r => r.GetAPSUserById(localAPSUserId)).Equals(localAPSUser);

            repository.VerifyAllExpectations();
        }
    }
}
