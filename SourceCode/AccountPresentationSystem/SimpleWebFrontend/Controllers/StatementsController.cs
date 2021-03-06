﻿using SimpleWebFrontend.App_Start;
using SimpleWebFrontend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebFrontend.Controllers
{
    [Authorize]
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
            List<AccountPresentationSystem.Domain.Model.StatementHandler.FakeStatement> Model = await StatementRepo.GetAllStatementsPerUser(FakeData.UserID);
            return View(Model);
        }

        // GET: Statement
        public async Task<ActionResult> Details(string Id)
        {
            AccountPresentationSystem.Domain.Model.StatementHandler.FakeStatement Model = await StatementRepo.GetSpecificStatement(Id);
            return View(Model);
        }
    }
}