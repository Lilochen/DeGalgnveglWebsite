using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_Galgnvegl.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUsIndex()
        {
            ViewBag.Message = "Das sind wir:";
            return View();
        }

    }
}
