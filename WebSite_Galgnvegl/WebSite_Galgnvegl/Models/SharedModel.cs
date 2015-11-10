using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_Galgnvegl.Models
{
    public class SharedModel
    {
        //var selectedData = db.Query("SELECT * FROM Markttermine1");
        public WebMatrix.Data.Database db = WebMatrix.Data.Database.Open("Connect_dbMarkt");
        public string selectedData =  "SELECT 'Datum_von', 'Datum_bis', 'Marktname', 'Ort' FROM 'tbMarkttermine";
        
       
        public SharedModel()
        {
            var model = HttpContext.Current.Session["SharedModel"];
        }        
        
    }
}