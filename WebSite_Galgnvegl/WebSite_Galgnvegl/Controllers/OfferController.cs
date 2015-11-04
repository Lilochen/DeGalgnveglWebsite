using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_Galgnvegl.Controllers
{
    public class OfferController : Controller
    {
        //
        // GET: /Offer/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OfferIndex()
        {
            ViewBag.Message = "Unser Angebot:";
            return View();
        }

        public ActionResult Camp()
        {
            ViewBag.Message = "Camp";
            return View();
        }

        public ActionResult ChainsOfFaith()
        {
            ViewBag.Message = "ChainsOfFaith";
            return View();
        }

        public ActionResult LiselottesGewandung()
        {
            ViewBag.Message = "LiselottesGewandung";
            return View();
        }

        public ActionResult MedivalManufactoring()
        {
            ViewBag.Message = "MedivalManufactoring";
            return View();
        }

        public ActionResult Workshop()
        {
            ViewBag.Message = "Workshop";
            return View();
        }

        public ActionResult Theater()
        {
            ViewBag.Message = "Theater";
            return View();
        }

    }
}
