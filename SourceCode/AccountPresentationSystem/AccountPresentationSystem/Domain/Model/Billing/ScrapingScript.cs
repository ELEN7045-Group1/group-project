using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPresentationSystem.Domain.Model.Billing
{
    public class ScrapingScript
    {
        public string ScriptName { get; set; }
        public string ScriptDescription { get; set; }
        public string ScriptSiteURL { get; set; }
        public string ScriptUsername { get; set; }
        public string ScriptPassword { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}
