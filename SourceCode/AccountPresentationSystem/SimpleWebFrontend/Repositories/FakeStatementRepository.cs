using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountPresentationSystem.Domain.Model.StatementHandler;
using AccountPresentationSystem.Domain.Model.APSUser;

namespace SimpleWebFrontend.Repositories
{
    public class FakeStatementRepository : IStatementRepository
    {
        public List<Statement> GetAllStatementsPerUser(APSUserId UserID)
        {
            List<Statement> retList = new List<Statement>();

            retList.Add(new Statement(new StatementId("ID1"), new StatementCommonFields(1, "Paul", DateTime.Now), new StatementType(1, "Type 1"), new StatementSpecificFields("Total Amount", "1050.00")));
            retList.Add(new Statement(new StatementId("ID2"), new StatementCommonFields(3, "Paul", DateTime.Now), new StatementType(3, "Type 3"), new StatementSpecificFields("Total Amount", "3320.30")));
            retList.Add(new Statement(new StatementId("ID3"), new StatementCommonFields(4, "Paul", DateTime.Now), new StatementType(1, "Type 1"), new StatementSpecificFields("Total Amount", "580.30")));

            return retList;
        }
    }
}