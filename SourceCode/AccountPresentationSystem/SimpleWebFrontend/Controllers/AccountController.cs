using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using SimpleWebFrontend.Models;
using AccountPresentationSystem.Domain.Model.APSUser;
using SimpleWebFrontend.Repositories;
using SimpleWebFrontend.App_Start;

namespace SimpleWebFrontend.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IAccountRepository AccountsRepo;

        public AccountController(IAccountRepository accountsRepo)
        {
            AccountsRepo = accountsRepo;
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    APSUser apsUser = AccountsRepo.GetUserAccountByUsernameAndPassword(model.Username, model.Password);
                    if (apsUser != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                        FakeData.UserID = apsUser.APSUserId.IdString;

                        if (this.Url.IsLocalUrl(returnUrl))
                            return Redirect(returnUrl);
                        else
                            return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Incorrect Username or Password");
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message.ToString());
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                APSUser user = new APSUser(new APSUserId(Guid.NewGuid().ToString()), model.Username, model.Password);
                AccountsRepo.InsertAPSUser(user);

                FormsAuthentication.SetAuthCookie(user.APSUsername, false);
                FakeData.UserID = user.APSUserId.IdString;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Manage()
        {
            ViewBag.HasLocalPassword = true;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Manage(ManageUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                APSUser user = AccountsRepo.GetUserAccountByUserID(FakeData.UserID);
                AccountsRepo.UpdateAPSUser(user);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            Error
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        private class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }
        }
        #endregion
    }
}