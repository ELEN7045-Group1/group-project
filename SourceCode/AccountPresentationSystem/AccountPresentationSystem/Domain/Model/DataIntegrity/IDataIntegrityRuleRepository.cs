namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IDataIntegrityRuleRepository
    {
        /// <summary>
        /// Gets all standard data integrity rules.
        /// </summary>
        /// <returns>
        /// Returns a list of standard integrity rules.
        /// </returns>
        List<DataIntegrityRule> GetStandardIntegrityRules();

        /// <summary>
        /// Gets all custom data integrity rules specific to billing company.
        /// </summary>
        /// <returns>
        /// Returns a list of custom integrity rules.
        /// </returns>
        List<DataIntegrityRule> GetCustomIntegrityRules();

        /// <summary>
        /// Gets all data integrity rules (standard and custom).
        /// </summary>
        /// <returns>
        /// Returns a list of all integrity rules.
        /// </returns>
        List<DataIntegrityRule> GetAllIntegrityRules();
    }
}