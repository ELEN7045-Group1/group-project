using SimpleWebFrontend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebFrontend.Controllers
{
    public class StatementsController : Controller
    {
        private readonly IStatementRepository StatementRepo;

        public StatementsController(IStatementRepository statementRepo)
        {
            StatementRepo = statementRepo;
        }

        // GET: Statement
        public async Task<ActionResult> Index()
        {
            List<AccountPresentationSystem.Domain.Model.StatementHandler.Statement> Model = await StatementRepo.GetAllStatementsPerUser(new AccountPresentationSystem.Domain.Model.APSUser.APSUserId("1"));
            return View(Model);
        }
    }
}