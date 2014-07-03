using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class StatementMunicipalitySpecificFields : StatementSpecificFields
    {
        private string Instalmentnotice;
        private int Electricityused;
        //etc
        
        public StatementMunicipalitySpecificFields(string [] listofspecificfields)
        {
            this.Instalmentnotice = listofspecificfields[0].ToString();
            this.Electricityused = int.Parse(listofspecificfields[1].ToString());
        }
    }
}