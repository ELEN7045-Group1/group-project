﻿namespace AccountPresentationSystem.Domain.Model.Billing
{
    using AccountPresentationSystem.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    public class BillingCompanyRepository : IBillingCompanyRepository
    {
        IDBConnection dataConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCompanyRepository"/> class.
        /// </summary>
        /// <param name="DBConnection">The database connection.</param>
        public BillingCompanyRepository(IDBConnection DBConnection)
        {
            this.dataConnection = DBConnection;
        }

        /// <summary>
        /// Gets all billing companies.
        /// </summary>
        /// <returns></returns>
        public List<BillingCompany> GetAllBillingCompanies()
        {
            List<BillingCompany> billingCompanies = new List<BillingCompany>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve All Billing Companies");

            foreach (DataRow dr in dt.Rows)
            {
                billingCompanies.Add(new BillingCompany((BillingCompanyId) dr["billingCompanyId"],(string)dr["companyName"]));
            }

            return billingCompanies;
        }

        /// <summary>
        /// Gets the billing company by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public BillingCompany GetBillingCompanyNameById(string id)
        {
            DataTable dt = dataConnection.SelectQuery("Select query to retrieve All Billing Companies");

            foreach (DataRow dr in dt.Rows)
            {
                if (dt.Rows.Count == 1)
                {
                    return  new BillingCompany((BillingCompanyId) dr["billingCompanyId"],(string)dr["companyName"]);
                }
            }

            return new BillingCompany(new BillingCompanyId("0"),"No Company Found");
        }
    }
}