using AccountPresentationSystem.Domain.Model.APSUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebFrontend.Repositories
{
    public interface IAccountRepository
    {
        APSUser GetUserAccountByUsernameAndPassword(string Username, string Password);
        APSUser GetUserAccountByUserID(string UserID);
        bool InsertAPSUser(APSUser user);
        bool UpdateAPSUser(APSUser user);
    }
}
