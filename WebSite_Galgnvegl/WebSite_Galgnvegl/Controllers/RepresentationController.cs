using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_Galgnvegl.Controllers
{
    public class RepresentationController : Controller
    {
        //
        // GET: /Representation/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RepresentationIndex()
        {
            ViewBag.Message = "Das Leben des Henkers im 13. Jahrhundert, seine Rechte und Pflichten";
            return View();
        }

        public ActionResult AsHealer()
        {
            ViewBag.Message = "Der Henker als Heiler";
            return View();
        }
        
        public ActionResult AsExecuter()
        {
            ViewBag.Message = "Der Henker als Vollstrecker";
            return View();
        }
        
        public ActionResult AsVeterian()
        {
            ViewBag.Message = "Der Henker als Veterinär";
            return View();
        }

        public ActionResult AsPunisher()
        {
            ViewBag.Message = "Der Henker als Folterer";
            return View();
        }

        public ActionResult AsCleaner()
        {
            ViewBag.Message = "Der Henker als Aufräumkommando";
            return View();
        }

        public ActionResult Situation13thCent()
        {
            ViewBag.Message = "Die allgemeine Situation im 13. Jahrhundert";
            return View();
        }

        public ActionResult GovSys13thCent()
        {
            ViewBag.Message = "Das Herschaftssystem im 13. Jahrhundert";
            return View();
        }

        public ActionResult LegalSys13thCent()
        {
            ViewBag.Message = "Das Rechtssystem im 13. Jahrhundert";
            return View();
        }

        public ActionResult EtiquettForHangmen()
        {
            ViewBag.Message = "Benimmregeln für den Henker";
            return View();
        }

        public ActionResult SocialRank()
        {
            ViewBag.Message = "Die soziale Stellung des Henkers und seiner Familie";
            return View();
        }

    }
}
