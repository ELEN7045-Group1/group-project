using AccountPresentationSystem.Domain.Model.APSUser;
using AccountPresentationSystem.Domain.Model.Billing;
using SimpleWebFrontend.App_Start;
using SimpleWebFrontend.Models;
using SimpleWebFrontend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebFrontend.Controllers
{
    [Authorize]
    public class BillingAccountsController : Controller
    {
        IBillingAccountsRepository BillingAccountRepo;
        IAccountRepository AccountRepo;

        public BillingAccountsController(IBillingAccountsRepository billingAccountRepo, IAccountRepository accountRepo)
        {
            BillingAccountRepo = billingAccountRepo;
            AccountRepo = accountRepo;
        }

        // GET: BillingAccounts
        public ActionResult Index()
        {
            List<BillingAccount> Model = BillingAccountRepo.GetBillingAccountsForUserID(FakeData.UserID);
            return View(Model);
        }

        public ActionResult Link()
        {
            ViewBag.CompanyID = new SelectList(FakeData.BillingCompanies, "BillingCompanyId.IdString", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Link(LinkBillingAccountViewModel Model)
        {
            if (ModelState.IsValid)
            {
                APSUser MyUser = AccountRepo.GetUserAccountByUserID(FakeData.UserID);
                BillingAccount BA = new BillingAccount(new BillingAccountId(Guid.NewGuid().ToString()), new BillingCompanyId(Model.CompanyID), Model.Username, Model.Password, MyUser);
                BillingAccountRepo.InsertBillingAccount(BA);
                return RedirectToAction("Index");
            }

            ViewBag.CompanyID = new SelectList(FakeData.BillingCompanies, "BillingCompanyId.IdString", "CompanyName");
            return View(Model);
        }
    }
}