﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_Galgnvegl.Controllers
{
    public class MarketsController : Controller
    {
        //
        // GET: /Markets/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MarketIndex()
        {
            ViewBag.Message = "Hier könnt ihr uns treffen:";
            return View();
        }

    }
}