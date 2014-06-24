using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Model.ErrorHandling
{
    public class BrokenScript : IErrorCondition
    {
        /// <summary>
        /// Initialises an ErrorCondition object
        /// </summary>
        /// <param name="errorCode">Error Code for the detected error condition</param>
        /// <param name="baseURL">Billing company's base URL</param>
        /// <param name="timeDetected">When was the error detected</param>
        public BrokenScript(Enumeration.ErrorCode errorCode, string baseURL, DateTime timeDetected)
        {
            ErrorCode = errorCode;
            BaseURL = baseURL;
            TimeDetected = timeDetected;
        }
        public Enumeration.ErrorCode ErrorCode
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string BaseURL
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime TimeDetected
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void ActOnError(Billing.BillingAccount billingAccount = null)
        {
            if (billingAccount != null)
            {
                var billingCompany = new BillingCompanyRepository(new DBConnection()).GetBillingCompanyNameById(billingAccount.BillingCompanyId.IdString);
                if (billingCompany != null)
                {
                    new Logging().LogMessage(Enumeration.LoggingPriority.Low, "123", string.Format("The script for {0} has been broken", billingCompany.CompanyName));
                }
            }
        }
    }
}