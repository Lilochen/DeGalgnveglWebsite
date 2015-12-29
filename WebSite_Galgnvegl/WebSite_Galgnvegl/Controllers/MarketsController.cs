using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_Galgnvegl.Models;

namespace WebSite_Galgnvegl.Controllers
{
    public class MarketsController : Controller
    {
        private MarketDBContent db = new MarketDBContent();

        public ActionResult MarketsIndex()
        {
            ViewBag.Message = "Hier könnt ihr uns treffen";
            return View(db.Markets.ToList());
        }      

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}