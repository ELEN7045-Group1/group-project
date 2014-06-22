namespace AccountPresentationSystem.Domain.Model.Credentials
{
    using AccountPresentationSystem.Domain.Model.Billing;
using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    /// <summary>
    /// APS user refers refers to the users of the APS system
    /// </summary>
    public class APSUser :IEntity<APSUser>
    {
        private readonly APSUserId _apsUserId;
        private readonly string _apsUserName;
        private readonly string _apsPassword;
        private readonly List<BillingAccount> _billingAccounts;

        /// <summary>
        /// Initializes a new instance of the <see cref="APSUser"/> class.
        /// </summary>
        /// <param name="apsUserId">The aps user identifier.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public  APSUser(APSUserId apsUserId, string username, string password)
        {
            if (apsUserId !=null && !string.IsNullOrEmpty(username) 
                && !string.IsNullOrEmpty(password))
            {
                this._apsUserId = apsUserId;
                this._apsUserName = username;
                this._apsPassword = password;
                this._billingAccounts = new List<BillingAccount>();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void  AddBillingAccount(BillingAccount billingAccount)
        {
            if (billingAccount!= null)
            {
                _billingAccounts.Add(billingAccount);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Gets the aps user identifier.
        /// </summary>
        /// <value>
        /// The aps user identifier.
        /// </value>
        public APSUserId APSUserId
        {
            get { return _apsUserId; }
        }

        /// <summary>
        /// Gets the aps username.
        /// </summary>
        /// <value>
        /// The aps username.
        /// </value>
        public string APSUsername
        {
            get { return _apsUserName; }
        }

        /// <summary>
        /// Gets the aps password.
        /// </summary>
        /// <value>
        /// The aps password.
        /// </value>
        public string APSPassword
        {
            get { return _apsPassword; }
        }

        public List<BillingAccount> BillingAccounts
        {
            get { return _billingAccounts; }
        }

        /// <summary>
        /// Entities compare by identity, not by attributes.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>
        /// true if the identities are the same, regardles of other attributes.
        /// </returns>
        public virtual bool SameIdentityAs(APSUser other)
        {
            return APSUserId.SameValueAs(other.APSUserId);
        }
    }
}