using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_Galgnvegl.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Impressum()
        {
            ViewBag.Message = "Impressum";
            return View();
        }

        public ActionResult Datenschutzerklaerung()
        {
            ViewBag.Message = "Datenschutzerklärung";
            return View();
        }
    }
}
