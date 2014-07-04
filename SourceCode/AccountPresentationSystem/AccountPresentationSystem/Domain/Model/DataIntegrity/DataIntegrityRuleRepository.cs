using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    public class DataIntegrityRuleRepository : IDataIntegrityRuleRepository
    {
        IDBConnection dataConnection;

        public DataIntegrityRuleRepository(IDBConnection DBConnection)
        {
            dataConnection = DBConnection;
        }

        public List<DataIntegrityRule> GetStandardIntegrityRules()
        {
            List<DataIntegrityRule> standardIntegrityRules = new List<DataIntegrityRule>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve only the Standard Integrity Rules");

            foreach (DataRow dr in dt.Rows)
            {
                standardIntegrityRules.Add(new DataIntegrityRule());
            }

            return standardIntegrityRules;
        }

        public List<DataIntegrityRule> GetCustomIntegrityRules()
        {
            List<DataIntegrityRule> customIntegrityRules = new List<DataIntegrityRule>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve only the Custom Integrity Rules");

            foreach (DataRow dr in dt.Rows)
            {
                customIntegrityRules.Add(new DataIntegrityRule());
            }

            return customIntegrityRules;
        }

        public List<DataIntegrityRule> GetAllIntegrityRules()
        {
            List<DataIntegrityRule> allIntegrityRules = new List<DataIntegrityRule>();

            DataTable dt = dataConnection.SelectQuery("Select query to retrieve all Integrity Rules");

            foreach (DataRow dr in dt.Rows)
            {
                allIntegrityRules.Add(new DataIntegrityRule());
            }

            return allIntegrityRules;
        }
    }
}