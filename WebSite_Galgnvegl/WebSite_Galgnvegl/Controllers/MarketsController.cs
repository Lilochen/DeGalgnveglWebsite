using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_Galgnvegl.Models;

namespace WebSite_Galgnvegl.Controllers
{
    public class MarketsController : Controller
    {
        //
        // GET: /Markets/

        WebSite_Galgnvegl.Models.SharedModel model = new Models.SharedModel();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MarketIndex()
        {
            ViewBag.Message = "Hier könnt ihr uns treffen:";
            return View(new SharedModel());
        }

    }
}
