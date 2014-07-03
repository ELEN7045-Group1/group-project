using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Shared;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerRules : IValueObject<LoadManagerRules>
    {
        public List<LoadManagerRule> LoadRules()
        {
            Logging log = new Logging();
            ReferenceGenerator refGen = new ReferenceGenerator();
            string refNum = refGen.GenerateReference();

            List<LoadManagerRule> loadManagerRules = new List<LoadManagerRule>();

            try
            {
                LoadManagerRuleRepository loadManagerRuleRepo = new LoadManagerRuleRepository();
                var rules = loadManagerRuleRepo.LoadRules();

                // Check and filter rules
                foreach (var item in rules)
                {
                    loadManagerRules.Add(item);
                }
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);
                loadManagerRules = new List<LoadManagerRule>();
            }

            return loadManagerRules;
        }

        public bool SameValueAs(LoadManagerRules other)
        {
            return true;
        }
    }
}