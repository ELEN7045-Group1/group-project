using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class StatementTelcoSpecificFields : StatementSpecificFields
    {
        private int TelephoneNumber;
        private int Servicecharges;
        //etc

        public StatementTelcoSpecificFields(string [] listofspecificfields)
        {
            this.TelephoneNumber = int.Parse(listofspecificfields[0].ToString());
            this.Servicecharges = int.Parse(listofspecificfields[1].ToString());
        }
    }
}