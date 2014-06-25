using SimpleWebFrontend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebFrontend.Controllers
{
    public class StatementController : Controller
    {
        private readonly IStatementRepository StatementRepo;

        public StatementController(IStatementRepository statementRepo)
        {
            StatementRepo = statementRepo;
        }

        // GET: Statement
        public ActionResult Index()
        {
            return View();
        }
    }
}