namespace AccountPresentationSystem.Domain.Model.APSUser
{
    using AccountPresentationSystem.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    public class APSUserRepository : IAPSUserRepository
    {
        IDBConnection dataConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCompanyRepository"/> class.
        /// </summary>
        /// <param name="DBConnection">The database connection.</param>
        public APSUserRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        public List<APSUser> GetAllAPSUsers()
        {
            List<APSUser> APSUsers = new List<APSUser>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve all APS Users");

            foreach (DataRow dr in dt.Rows)
            {
                APSUsers.Add(new APSUser((APSUserId)dr["apsUserId"], (string)dr["APSUsername"],
                    (string)dr["APSPassword"]));
            }

            return APSUsers;
        }

        public APSUser GetAPSUserById(APSUserId apsUserId)
        {
            APSUser localAPSUser;
            DataTable dt = dataConnection.SelectQuery("Select query to retrieve APS User by APSUserId");

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                localAPSUser = new APSUser((APSUserId)dr["apsUserId"], (string)dr["apsUsername"], (string)dr["apsUserPassword"]);
            }
            else
            {
                throw new Exception("There can be only one APS User per APSUserId");
            }

            return localAPSUser;
        }
    }
}