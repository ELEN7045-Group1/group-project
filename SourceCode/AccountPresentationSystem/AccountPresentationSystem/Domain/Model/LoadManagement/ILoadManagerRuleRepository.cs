using System;
using System.Collections.Generic;
namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public interface ILoadManagerRuleRepository
    {
        List<LoadManagerRule> LoadRules();
    }
}
