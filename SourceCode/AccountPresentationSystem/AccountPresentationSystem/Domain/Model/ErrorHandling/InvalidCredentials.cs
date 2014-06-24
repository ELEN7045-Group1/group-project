using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.ErrorHandling
{
    public class InvalidCredentials : IErrorCondition
    {
       /// <summary>
        /// Initialises an ErrorCondition object
        /// </summary>
        /// <param name="errorCode">Error Code for the detected error condition</param>
        /// <param name="baseURL">Billing company's base URL</param>
        /// <param name="timeDetected">When was the error detected</param>
        public InvalidCredentials(Enumeration.ErrorCode errorCode, string baseURL, DateTime timeDetected)
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

        public void ActOnError(BillingAccount billingAccount = null)
        {
            throw new NotImplementedException();
        }

    }
}