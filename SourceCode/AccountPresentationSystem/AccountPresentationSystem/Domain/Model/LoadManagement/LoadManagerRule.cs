﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerRule
    {
        public string RuleName { get; set; }
        public string RuleDescription { get; set; }
        public string RuleCategory { get; set; }
        public string RulePriority { get; set; }
    }
}
