using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_Galgnvegl.Models
{
    public class SharedModel
    {
        public WebMatrix.Data.Database db = WebMatrix.Data.Database.Open("defaultconnection");
        public string selectedData = "SELECT 'Datum(von)', '(bis)', 'Markt', 'Ort' FROM 'tableMarkttermine";
        public SharedModel()
        {
            var model = HttpContext.Current.Session["SharedModel"];
        }        
        
    }
}