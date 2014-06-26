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
            return new List<Statement>();
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
