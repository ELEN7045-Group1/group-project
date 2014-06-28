using System;
using System.Collections.Generic;
namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    interface ILoadManagerRuleRepository
    {
        List<LoadManagerRule> LoadRules();
    }
}
