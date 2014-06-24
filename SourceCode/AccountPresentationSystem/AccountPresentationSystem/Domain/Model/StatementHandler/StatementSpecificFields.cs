using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    /// <summary>
    /// Refer to specific statement data fields according a statement type
    /// For future developer will have to with of a better way of doing this as this is a generic template for all statement type and field all set to string 
    /// no time to change this now
    /// </summary>
    public class StatementSpecificFields
    {
        private readonly string _statementfieldname1;
        private readonly string _statementfieldvalue1;
        // Would a be a lot more field than this


        public StatementSpecificFields(string statementfieldname1, string statementfieldvalue1)
        {
             this._statementfieldname1 = statementfieldname1;
             this._statementfieldvalue1 = statementfieldvalue1;
        }

        /// <summary>
        /// Gets the identifier string
        /// </summary>
        /// <value>
        /// The identifier string
        /// </value>
        public string StatementFieldName1
        {
            get { return _statementfieldname1; }
        }

        /// <summary>
        /// Gets the identifier string
        /// </summary>
        /// <value>
        /// The identifier string
        /// </value>
        public string StatementFieldValue1
        {
            get { return _statementfieldvalue1; }
        }
        
        public bool SameValueAs(StatementCommonFields other)
        {
            return true;
        }
    }
}