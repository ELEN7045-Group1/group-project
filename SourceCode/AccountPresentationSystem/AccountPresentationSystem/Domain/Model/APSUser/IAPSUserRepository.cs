namespace AccountPresentationSystem.Domain.Model.APSUser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IAPSUserRepository
    {
        List<APSUser> GetAllAPSUsers();

        APSUser GetAPSUserById(APSUserId apsUserId);
    }
}