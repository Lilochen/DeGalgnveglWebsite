using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using WebSite_Galgnvegl.Models;


namespace WebSite_Galgnvegl.Controllers
{
    public class ToolsController : Controller
    {
        //
        // GET: /Tools/
        private MarketDBContent Mdb = new MarketDBContent();
        private AccountDBContent Adb = new AccountDBContent();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MarketsInterna()
        {
            ViewBag.Message = "Hier könnt ihr uns treffen";
            return View(Mdb.Markets.ToList());
        } 

        public ActionResult CodeGenerator()
        {
            return View();
        }



    }
}
