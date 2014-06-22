namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Model.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class BillingAccount
    {
        private readonly BillingAccountId _billingAccountId;
        private readonly BillingCompanyId _billingCompanyId;
        private readonly string _billingAccountUsername;
        private readonly string _billingAccountPassword;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAccount"/> class.
        /// </summary>
        /// <param name="billingAccountId">The billing account identifier.</param>
        /// <param name="billingCompanyId">The billing company identifier.</param>
        /// <param name="billingAccountUsername">The billing account username.</param>
        /// <param name="billingAccountPassword">The billing account password.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public BillingAccount(BillingAccountId billingAccountId, BillingCompanyId billingCompanyId, 
            string billingAccountUsername, string billingAccountPassword)
        {
            if (billingAccountId != null && billingCompanyId !=null &&
                !string.IsNullOrEmpty(billingAccountUsername) && !string.IsNullOrEmpty(billingAccountPassword))
            {
                _billingAccountId = billingAccountId;
                _billingCompanyId = billingCompanyId;
                _billingAccountUsername = billingAccountUsername;
                _billingAccountPassword = billingAccountPassword;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Gets the billing account identifier.
        /// </summary>
        /// <value>
        /// The billing account identifier.
        /// </value>
        public BillingAccountId BillingAccountId
        {
            get { return _billingAccountId; }
        }

        /// <summary>
        /// Gets the billing company identifier.
        /// </summary>
        /// <value>
        /// The billing company identifier.
        /// </value>
        public BillingCompanyId BillingCompanyId
        {
            get { return _billingCompanyId; }
        }

        /// <summary>
        /// Gets the billing account username.
        /// </summary>
        /// <value>
        /// The billing account username.
        /// </value>
        public string BillingAccountUsername
        {
            get { return _billingAccountUsername; }
        }

        /// <summary>
        /// Gets the billing account password.
        /// </summary>
        /// <value>
        /// The billing account password.
        /// </value>
        public string BillingAccountPassword
        {
            get { return _billingAccountPassword; }
        }

        /// <summary>
        /// Entities compare by identity, not by attributes.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>
        /// true if the identities are the same, regardles of other attributes.
        /// </returns>
        public virtual bool SameIdentityAs(BillingAccount other)
        {
            return BillingAccountId.SameValueAs(other.BillingAccountId);
        }

    }


}