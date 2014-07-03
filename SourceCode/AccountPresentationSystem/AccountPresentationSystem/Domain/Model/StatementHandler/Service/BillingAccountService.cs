namespace AccountPresentationSystem.Domain.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class BillingAccountService : IBillingAccountService
    {
        /// <summary>
        /// Creates the billing account identifier.
        /// </summary>
        /// <returns></returns>
        public string CreateBillingAccountId()
        {
            string billingAccountId;

            billingAccountId = "BAIDNO_" + sixDigitRandomNumGenreator();

            return billingAccountId;
        }

        /// <summary>
        /// Six digit random number genreator.
        /// </summary>
        /// <returns></returns>
        private string sixDigitRandomNumGenreator()
        {
            string sixDigitString = "";
            Random rnd = new Random();

           for (int ctr = 1; ctr <= 6; ctr++)
           {
                    sixDigitString += ctr;
           }

           return sixDigitString;
        }
    }
}