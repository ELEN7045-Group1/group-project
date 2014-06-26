using AccountPresentationSystem.Domain.Model.APSUser;
using SimpleWebFrontend.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebFrontend.Repositories
{
    public class FakeAccountRepository : IAccountRepository
    {
        public APSUser GetUserAccountByUsernameAndPassword(string Username, string Password)
        {
            return FakeData.Users.Where(x => (x.APSUsername == Username) && (x.APSPassword == Password)).FirstOrDefault();
        }

        public APSUser GetUserAccountByUserID(string UserID)
        {
            return FakeData.Users.Where(x => (x.APSUserId.IdString == UserID)).FirstOrDefault();
        }

        public bool InsertAPSUser(APSUser user)
        {
            try
            {
                FakeData.Users.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAPSUser(APSUser user)
        {
            try
            {
                int index = FakeData.Users.FindIndex(x => x.APSUserId.IdString == user.APSUserId.IdString);
                FakeData.Users[index] = user;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}