namespace AccountPresentationSystem.Domain.Model.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IBillingCompanyRepository
    {
        /// <summary>
        /// Gets all billing companies.
        /// </summary>
        /// <returns></returns>
        List<BillingCompany> GetAllBillingCompanies();

        /// <summary>
        /// Gets the billing company name by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        BillingCompany GetBillingCompanyNameById(string id);
    }
}