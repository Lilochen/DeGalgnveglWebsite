using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebSite_Galgnvegl.Models;

namespace WebSite_Galgnvegl.Models
{
    public class User
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Passwort")]
        public string Password { get; set; }

        [Display(Name = "Angemeldet bleiben?")]
        public bool RememberMe { get; set; }

        public bool IsValid(string username, string password)
        {
            //Überprüfen, ob eingegebener User mit eingegebenen Passwort in DB existiert

        }
    }
}