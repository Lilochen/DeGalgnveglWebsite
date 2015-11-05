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
        
        public ActionResult IgorWorjaz()
        {
            ViewBag.Message = "Igor Worjaz";
            return View();
        }

        public ActionResult SteapaSnotor()
        {
            ViewBag.Message = "Steapa Snotor";
            return View();
        }

        public ActionResult LiselotteVonZellrudndorff()
        {
            ViewBag.Message = "Liselotte von Zellrudndorff";
            return View();
        }

        public ActionResult LamiaDieSanfte()
        {
            ViewBag.Message = "Lamia die Sanfte";
            return View();
        }

        public ActionResult Simon()
        {
            ViewBag.Message = "Simon";
            return View();
        }

        public ActionResult Grygr()
        {
            ViewBag.Message = "Grygr";
            return View();
        }

        public ActionResult PaterJudas()
        {
            ViewBag.Message = "Pater Judas";
            return View();
        }

    }
}
