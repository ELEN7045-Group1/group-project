using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class SpecificFieldsFactory
    {

        public StatementSpecificFields createSpecificFields(string statementtypename, string[] listspecificfields)
        {
            StatementSpecificFields _specificfields = null;
            if (statementtypename.Equals("Municipality"))
            {
                _specificfields = new StatementMunicipalitySpecificFields(listspecificfields);
            }
            else if (statementtypename.Equals("CreditCardProvider"))
            {
                _specificfields = new StatementCreditCardSpecificFields(listspecificfields);
            }
            else if (statementtypename.Equals("TelcoProvider"))
            {
                _specificfields = new StatementTelcoSpecificFields(listspecificfields);
            }

            return _specificfields;
        }
    }
}
