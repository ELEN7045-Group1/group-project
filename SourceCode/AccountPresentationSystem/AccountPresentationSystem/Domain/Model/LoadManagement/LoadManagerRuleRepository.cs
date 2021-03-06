﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Infrastructure;
using AccountPresentationSystem.Domain.Shared;

namespace AccountPresentationSystem.Domain.Model.LoadManagement
{
    public class LoadManagerRuleRepository : ILoadManagerRuleRepository
    {
        private readonly IDBConnection dataConnection;

        public LoadManagerRuleRepository()
        {
            //this.dataConnection = DBConnection;
        }

        public List<LoadManagerRule> LoadRules()
        {
            Logging log = new Logging();
            ReferenceGenerator refGen = new ReferenceGenerator();
            string refNum = refGen.GenerateReference();

            List<LoadManagerRule> listRules = new List<LoadManagerRule>();
            
            try
            {
                // This retrieves all Load Manager Rules via the DBConnetion
                listRules = new List<LoadManagerRule>();
            }
            catch (Exception ex)
            {
                log.LogMessage(Enumeration.LoggingPriority.High, refNum, ex);

                listRules.Add(new LoadManagerRule());
            }

            return listRules;
        }
    }
}