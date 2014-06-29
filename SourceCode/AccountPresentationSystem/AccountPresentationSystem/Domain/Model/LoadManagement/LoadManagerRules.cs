﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerRules
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
    }
}