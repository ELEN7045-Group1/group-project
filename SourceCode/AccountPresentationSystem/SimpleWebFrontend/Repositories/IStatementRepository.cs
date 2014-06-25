using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebFrontend.Repositories
{
    public interface IStatementRepository
    {
        List<Statement> GetAllStatementsPerUser(APSUserId UserID);
    }
}
