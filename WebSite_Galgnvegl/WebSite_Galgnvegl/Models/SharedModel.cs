using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BotDetect.Web.UI.Mvc;

namespace WebSite_Galgnvegl.Models
{
    public class SharedModel
    {
        //var selectedData = db.Query("SELECT * FROM Markttermine1");
        //public WebMatrix.Data.Database db = WebMatrix.Data.Database.Open("Connect_dbMarkt");
        public string selectedData =  "SELECT 'Datum_von', 'Datum_bis', 'Marktname', 'Ort' FROM 'tbMarkttermine";

        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set; }
        public string Marketname { get; set; }
        public string Locationname { get; set; }
        public string URL { get; set; }
        
        public bool isHuman { get; set; }
        public MvcCaptcha myCaptcha;
       
        public SharedModel()
        {
            myCaptcha = new MvcCaptcha("SampleCaptcha");
            myCaptcha.UserInputClientID = "CapchaCode";
        }        
        
    }
}