using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using AccountPresentationSystem.Domain.Model.APSUser;
using System.Threading.Tasks;
using SimpleWebFrontend.App_Start;

namespace SimpleWebFrontend.Repositories
{
    public class FakeStatementRepository : IStatementRepository
    {
        public async Task<List<Statement>> GetAllStatementsPerUser(APSUserId UserID)
        {
            return FakeData.Statements.Where(x => x.APSUser.APSUserId.SameValueAs(UserID)).ToList();
        }

        public async Task<Statement> GetSpecificStatement(StatementId StatementId)
        {
            return FakeData.Statements.Where(x => x.StatementId.StatementIdString == StatementId.StatementIdString).FirstOrDefault();
        }

    }
}