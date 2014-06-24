using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.ErrorHandling
{
    /// <remarks>
    /// A number of possible error conditions are detected by the scraper. These errors are reported via
    /// the XML file. When an error occurs the XML file will contain only the base-url, date and time
    /// of the scraping attempt and the relevant error code, if the source of the error can be detected.
    /// </remarks>
    public interface IErrorCondition
    {

        /// <summary>
        /// Error code if the type of error can be detected
        /// </summary>
        Enumeration.ErrorCode ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// The base URL for the billing company
        /// </summary>
        string BaseURL
        {
            get;
            set;
        }

        /// <summary>
        /// The time when the error was detected or raised
        /// </summary>
        DateTime TimeDetected
        {
            get;
            set;
        }

        void ActOnError(BillingAccount billingAccount = null);
    }
}
