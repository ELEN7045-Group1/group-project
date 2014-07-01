using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    /// <summary>
    /// Refers to common fields 
    /// for purposes of demostration am only showing a few fields 
    /// </summary>
    public class StatementCommonFields : IValueObject<StatementCommonFields>
    {
        private readonly int _statementAccountnumber;
        private readonly string _statementAccountholdername;
        private readonly DateTime _statementDate;
        // Would a be a lot more field than this just showing it would be like


        public StatementCommonFields(int statementAccountnumber, string statementAccountholdername, DateTime statementDate)
        {
            this._statementAccountnumber = statementAccountnumber;
            this._statementAccountholdername = statementAccountholdername;
            this._statementDate = statementDate; 
        }

        /// <summary>
        /// Gets the identifier int
        /// </summary>
        /// <value>
        /// The identifier int.
        /// </value>
        public int StatementAccountNumber
        {
            get { return _statementAccountnumber; }
        }

        /// <summary>
        /// Gets the identifier string
        /// </summary>
        /// <value>
        /// The identifier string
        /// </value>
        public string StatementAccountHolderName
        {
            get { return _statementAccountholdername; }
        }

        /// <summary>
        /// Gets the identifier DateTime
        /// </summary>
        /// <value>
        /// The identifier DateTime
        /// </value>
        public DateTime StatementDate
        {
            get { return _statementDate; }
        }


        public bool SameValueAs(StatementCommonFields other)
        {
            return true;
        }
    }
}