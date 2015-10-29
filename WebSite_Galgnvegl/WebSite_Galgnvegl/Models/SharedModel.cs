using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_Galgnvegl.Models
{
    public class SharedModel
    {
        public WebMatrix.Data.Database db = WebMatrix.Data.Database.Open("DefaultConnection");
        //string selectedData = "SELECT *"
    }
}