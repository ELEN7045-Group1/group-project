namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public interface IDataIntegrityRuleRepository
    {
        List<DataIntegrityRule> GetStandardIntegrityRules();

        List<DataIntegrityRule> GetCustomIntegrityRules();

        List<DataIntegrityRule> GetAllIntegrityRules();
    }
}