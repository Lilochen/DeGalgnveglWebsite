using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
            //wurden Name/ Passwort eingegeben?
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
                    @"=|DataDirectory|\dbMarkt.mdf;" +
                    @"Integrated Security=True")) 
                {
                    string SELECT_USER = @"SELECT [UserName] FROM [dbo].[AccountDatabase] WHERE [UserName] = @u AND [Password] = @p";
                    var cmd = new SqlCommand(SELECT_USER, cn);
                    cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.VarChar)).Value = username;                    
                    cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = Helpers.SHA1.Encode(password);
                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Dispose();
                        cmd.Dispose();
                        return true;
                    }
                    else 
                    {
                        reader.Dispose();
                        cmd.Dispose();
                        return false;
                    }
                }
            }
        }
    }
}