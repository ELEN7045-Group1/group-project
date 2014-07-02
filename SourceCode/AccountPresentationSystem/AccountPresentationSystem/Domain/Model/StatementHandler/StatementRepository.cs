using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public class StatementRepository : IStatementRepository
    {
        public async Task<List<Statement>> GetAllStatementsPerUser(APSUserId UserID)
        {
            //Gets a specific statements for a user
            //code logic return null for now
            return null;
        }

        public async Task<Statement> GetSpecificStatement(StatementId StatementId)
        {
            //Gets a specific statement
            //code logic return null for now
            return null;
        } 
    
        public bool SaveStatement(Statement statement)
        {
            //Saves statement
            //code logic return true for now
            return true;
        }
    }
 }