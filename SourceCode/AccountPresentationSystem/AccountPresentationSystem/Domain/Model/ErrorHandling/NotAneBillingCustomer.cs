using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.ErrorHandling
{
    public class NotAneBillingCustomer : IErrorCondition
    {
        /// <summary>
        /// Initialises an ErrorCondition object
        /// </summary>
        /// <param name="errorCode">Error Code for the detected error condition</param>
        /// <param name="baseURL">Billing company's base URL</param>
        /// <param name="timeDetected">When was the error detected</param>
        public NotAneBillingCustomer(int errorCode, string baseURL, DateTime timeDetected)
        {
            ErrorCode = errorCode;
            BaseURL = baseURL;
            TimeDetected = timeDetected;
        }
        
        public int ErrorCode
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
            throw new NotImplementedException();
        }
    }
}