namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Billing Company
    /// </summary>
    public class BillingCompany : IEntity<BillingCompany>
    {
        private readonly BillingCompanyId _billingCompanyId;
        private readonly string companyName;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCompany"/> class.
        /// </summary>
        /// <param name="billingCompanyId">The billing company identifier.</param>
        /// <param name="companyName">Name of the company.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public BillingCompany(BillingCompanyId billingCompanyId,string companyName)
        {
            if (billingCompanyId == null && string.IsNullOrEmpty(companyName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                this._billingCompanyId = billingCompanyId;
                this.companyName = companyName;
            }           
        }

        /// <summary>
        /// Gets the billing company identifier.
        /// </summary>
        /// <value>
        /// The billing company identifier.
        /// </value>
        public BillingCompanyId billingCompanyId
        {
            get { return _billingCompanyId; }
        }

        /// <summary>
        /// Gets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName
        {
            get { return companyName; }
        }

        /// <summary>
        /// Entities compare by identity, not by attributes.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>
        /// true if the identities are the same, regardles of other attributes.
        /// </returns>
        public virtual bool SameIdentityAs(BillingCompany other)
        {
            return billingCompanyId.SameValueAs(other.billingCompanyId);
        }
    }
}