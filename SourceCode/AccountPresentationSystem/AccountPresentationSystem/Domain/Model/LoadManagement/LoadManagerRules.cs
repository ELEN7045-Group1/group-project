using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerRules : IValueObject<LoadManagerRules>
    {
        public List<LoadManagerRule> LoadRules()
        {
            List<LoadManagerRule> loadManagerRules = new List<LoadManagerRule>();

            LoadManagerRuleRepository loadManagerRuleRepo = new LoadManagerRuleRepository();
            var rules = loadManagerRuleRepo.LoadRules();

            // Check and filter rules
            foreach (var item in rules)
            {
                loadManagerRules.Add(item);
            }

            return loadManagerRules;
        }

        public bool SameValueAs(LoadManagerRules other)
        {
            return true;
        }
    }
}