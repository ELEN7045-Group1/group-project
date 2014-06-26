namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    using AccountPresentationSystem.Domain.Model.Billing;
using AccountPresentationSystem.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    /// <summary>
    /// Refers the final statement for customer
    /// Theoretical this class in actually pull from the Statement Repo it does so it interact with the rest of the objects 
    /// at this stage it will more be for display purposes  
    /// </summary>
    public class Statement : IEntity<Statement>
    {
        private readonly StatementId _statementId;
        private readonly StatementCommonFields _statementCommonFields;
        private readonly StatementType _statementType;
        private readonly List<StatementSpecificFields> _statementSpecificFields;
        private readonly APSUser.APSUser _apsuser;
        private readonly BillingAccount _billingAccount;

        /// <summary>
        /// Initializes a new instance of the <see cref="APSUser"/> class.
        /// </summary>
        /// <param name="StatementId">Statement identifier.</param>
        /// <param name="StatementCommonFields">Common field for all statements.</param>
        /// <param name="StatementType">Identifies the what type for statements this is</param>
        /// <param name="SpecificFields">Specific Fields allocated to statement based on  statement type</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public Statement(StatementId statementId, StatementCommonFields statementCommonFields, StatementType statementType, List<StatementSpecificFields> statementSpecificFields, APSUser.APSUser apsuser, BillingAccount billingAccount)
        {
            if (statementId != null && statementCommonFields != null && statementType != null && statementSpecificFields != null)
            {
                this._statementId = statementId;
                this._statementCommonFields = statementCommonFields;
                this._statementType = statementType;
                this._statementSpecificFields = statementSpecificFields;
                this._apsuser = apsuser;
                this._billingAccount = billingAccount;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void DisplayStatement()
        {
            // this method would send the statement to the the statement layout creator to display the statement 
        }

        /// <summary>
        /// Gets the statement Identifier.
        /// </summary>
        public StatementId StatementId
        {
            get { return _statementId; }
        }

        /// <summary>
        /// Gets the statement common fields.
        /// </summary>
        public StatementCommonFields StatementCommonFields
        {
            get { return _statementCommonFields; }
        }

        /// <summary>
        /// Gets the statement type 
        /// </summary>
        public StatementType StatementType
        {
            get { return _statementType; }
        }

        /// <summary>
        /// Gets the statement type 
        /// </summary>
        public List<StatementSpecificFields> StatementSpecificFields
        {
            get { return _statementSpecificFields; }
        }

        /// <summary>
        /// Gets the statement type 
        /// </summary>
        public APSUser.APSUser APSUser
        {
            get { return _apsuser; }
        }

        /// <summary>
        /// Gets the statement type 
        /// </summary>
        public BillingAccount BillingAccount
        {
            get { return _billingAccount; }
        }


        /// <summary>
        /// Entities compare by identity, not by attributes.
        /// </summary>
        /// <param name="other">The other entity.</param>
        /// <returns>
        /// true if the identities are the same, regardles of other attributes.
        /// </returns>
        public virtual bool SameIdentityAs(Statement other)
        {
            return StatementId.SameValueAs(other._statementId);
        }
    }
}