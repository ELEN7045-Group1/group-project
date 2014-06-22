namespace AccountPresentationSystem.Domain.Billing
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    
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
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public virtual bool SameIdentityAs(BillingCompany other)
        {
            return billingCompanyId.SameValueAs(other.billingCompanyId);
        }
    }
}