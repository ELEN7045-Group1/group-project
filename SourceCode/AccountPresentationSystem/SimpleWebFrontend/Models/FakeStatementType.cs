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
    public class FakeStatementType : IValueObject<FakeStatementType>
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private readonly int _statementtypeno;
        private readonly string _statementtypename;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementId"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public FakeStatementType(int statementtypeno, string statementtypename)
        {
                this._statementtypeno = statementtypeno;
                this._statementtypename = statementtypename;
        }

        /// <summary>
        /// Gets the identifier int
        /// </summary>
        /// <value>
        /// The identifier int.
        /// </value>
        public int StatementTypeNo
        {
            get { return _statementtypeno; }
        }

        /// <summary>
        /// Gets the identifier string
        /// </summary>
        /// <value>
        /// The identifier string
        /// </value>
        public string StatementTypeName
        {
            get { return _statementtypename; }
        }

      

        public bool SameValueAs(FakeStatementType other)
        {
            return StatementTypeNo.Equals(other.StatementTypeNo);
        }

    }
}