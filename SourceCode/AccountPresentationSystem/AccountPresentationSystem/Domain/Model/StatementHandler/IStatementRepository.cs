using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.StatementHandler
{
    public interface IStatementRepository
    {
        void SaveStatement();
        List<Statement> GetStatement();
        
    }

}