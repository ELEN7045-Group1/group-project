using AccountPresentationSystem.Domain.Model.StatementHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccountPresentationSystem.Application.Controllers
{
    public class StatementsController : ApiController
    {
        // GET: api/Statements
        public IEnumerable<Statement> Get()
        {
            List<Statement> retList = new List<Statement>();

            retList.Add(new Statement(new StatementId("ID1"), new StatementCommonFields(1, "Paul", DateTime.Now), new StatementType(1, "Type 1"), new StatementSpecificFields("Total Amount", "1050.00")));
            retList.Add(new Statement(new StatementId("ID2"), new StatementCommonFields(3, "Paul", DateTime.Now), new StatementType(3, "Type 3"), new StatementSpecificFields("Total Amount", "3320.30")));
            retList.Add(new Statement(new StatementId("ID3"), new StatementCommonFields(4, "Paul", DateTime.Now), new StatementType(1, "Type 1"), new StatementSpecificFields("Total Amount", "580.30")));

            return retList;
        }

        // GET: api/Statements/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Statements
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Statements/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Statements/5
        public void Delete(int id)
        {
        }
    }
}
