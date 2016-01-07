using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebSite_Galgnvegl.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (user.IsValid(user.UserName, user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                return RedirectToAction("MarketsInterna", "Tools");
            }
            else
            {
                ModelState.AddModelError("", "Bitte Anmeldedaten prüfen!");
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}
