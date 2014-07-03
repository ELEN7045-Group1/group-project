using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class StatementCreditCardSpecificFields : StatementSpecificFields
    {
        private string Cardtype;
        private int InterestRate;
        //etc

        public StatementCreditCardSpecificFields(string [] listofspecificfields)
        {
            this.Cardtype = listofspecificfields[0].ToString();
            this.InterestRate = int.Parse(listofspecificfields[1].ToString());
        }
    }
}