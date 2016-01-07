using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSite_Galgnvegl.Models
{
    public class AccountDatabase
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //https://msdn.microsoft.com/de-de/data/jj193542.aspx
        //Für Änderungen migrieren! Link folgen!!!
    }

    public class AccountDBContent : DbContext
    {
        public DbSet<AccountDatabase> Accounts { get; set; }
    }



}