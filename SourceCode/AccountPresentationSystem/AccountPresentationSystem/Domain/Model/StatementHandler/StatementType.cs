using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    /// <summary>
    /// Refers the statement type of the statement E.g 1 = Municpalities 2 = Credit Cards Providers 3 = Telco Service Providers
    /// </summary>
    public class StatementType : IValueObject<StatementType>
    {
        private SpecificFieldsFactory _factory;
        private string _statementtypename;
        private string[] _listspecificfields;


        public StatementType(SpecificFieldsFactory factory, string statementtypename, string[] listspecificfields)
        {
            this._factory = factory;
            this._statementtypename = statementtypename;
            this._listspecificfields = listspecificfields;
        }

        public string StatementTypeName
        {
            get { return _statementtypename; }
        }

        public StatementSpecificFields getSpecificFields() 
        {
            StatementSpecificFields _specificfields;
            _specificfields = _factory.createSpecificFields(_statementtypename, _listspecificfields);
            return _specificfields;
        }


        public bool SameValueAs(StatementType other)
        {
            return other != null && _statementtypename.Equals(other.StatementTypeName);
        }


        

        
    }
}