using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSite_Galgnvegl.Models
{
    public class Marketdatabase
    {
        public int ID { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set; }
        public string Marketname { get; set; }
        public string Location { get; set; }
        public string URL { get; set; }         
    }

    public class MarketDBContent : DbContext
    {      
        public DbSet<Marketdatabase> Markets { get; set; }
    }
}