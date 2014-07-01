using AccountPresentationSystem.Domain.Model.APSUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public interface IStatementRepository
    {
        Task<List<Statement>> GetAllStatementsPerUser(APSUserId UserID);
        Task<Statement> GetSpecificStatement(StatementId StatementID);
    }

}