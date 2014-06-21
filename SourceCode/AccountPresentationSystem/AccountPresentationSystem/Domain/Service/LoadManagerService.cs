using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Infrastructure;

namespace AccountPresentationSystem.Domain.Service
{
    public class LoadManagerService
    {
        private Logging log = new Logging();
        public string refNum = "";

        public bool CreateLoadManager()
        {
            ReferenceGenerator refNumber = new ReferenceGenerator();
            string refNum = refNumber.GenerateReference();
            return false;
        }
    }
}