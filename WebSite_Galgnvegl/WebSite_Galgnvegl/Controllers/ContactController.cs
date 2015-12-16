using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace WebSite_Galgnvegl.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactIndex()
        {
            ViewBag.Message = "Kontaktiere uns:";
            return View();
        }

        [HttpPost]
        public ActionResult SendEMail(string Mail_Subject, string Mail_Message, string Mail_Name, string Mail_Tel, string Mail_To)
        {
            MailMessage mail = new MailMessage();


            mail.From = new MailAddress(Mail_To);
            mail.To.Add("DeGalgnvegl@gmail.com");
            mail.Subject = Mail_Subject;
            if (Mail_Tel == "")
            {
                mail.Body = "E-Mail-Adresse: " + Mail_To + "\n" + "Name: " + Mail_Name + "\n" + "Telefon: Nicht angegeben" + "\n" + "Nachricht:\n" + Mail_Message;
            }
            else
            {
                mail.Body = "E-Mail-Adresse: " + Mail_To + "\n" + "Name: " + Mail_Name + "\n" + "Telefon: " + Mail_Tel + "\n" + "Nachricht:\n" + Mail_Message;
            }

            SmtpClient Smtpclient = new SmtpClient("smtp.gmail.com", 587);

            try
            {
                Smtpclient.Credentials = new System.Net.NetworkCredential("DeGalgnvegl@gmail.com", "Galgnvogl");        //Anmeldung am SMTP-Server
                Smtpclient.EnableSsl = true;                            //SSL Verschlüsselung erlauben                
                Smtpclient.Send(mail);                                  //Senden der E-Mail

                WebSite_Galgnvegl.Models.Result result = new Models.Result(true);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                WebSite_Galgnvegl.Models.Result result = new Models.Result(false);
                return Json(result, JsonRequestBehavior.AllowGet);

            }

        }

    }
}
