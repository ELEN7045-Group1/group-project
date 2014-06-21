namespace AccountPresentationSystem.Domain.Billing
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    
    public class BillingCompany : IEntity<BillingCompany>
    {
        private readonly BillingCompanyId billingCompanyId;
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
                this.billingCompanyId = billingCompanyId;
                this.companyName = companyName;
            }           
        }

        //public string IdString
        //{
        //    get { return id; }
        //}

        ////public string IdString
        ////{
        ////    get { return id; }
        ////}

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