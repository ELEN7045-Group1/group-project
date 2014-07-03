using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AccountPresentationSystem.Domain.Model.LoadManagement;

namespace AccountPresentationSystem.Application.Controllers
{
    public class LoadManageerController: ApiController
    {
        private readonly ILoadManagerRuleRepository loadManagerRuleRepository;

        public LoadManageerController(ILoadManagerRuleRepository loadManagerRuleRepository)
        {
            this.loadManagerRuleRepository = loadManagerRuleRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            List<LoadManagerRule> rules = loadManagerRuleRepository.LoadRules();

            return new string[] { "value1", "value2" };
        }
    }
}