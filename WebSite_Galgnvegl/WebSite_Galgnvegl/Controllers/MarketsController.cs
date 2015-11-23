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
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        using (var db = new BlogContext())
    //        {
    //            db.Blogs.Add(new Blog { Name = "Another Blog " });
    //            db.SaveChanges();

    //            foreach (var blog in db.Blogs)
    //            {
    //                Console.WriteLine(blog.Name);
    //            }
    //        }

    //        Console.WriteLine("Press any key to exit...");
    //        Console.ReadKey();
    //    }
    //}

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