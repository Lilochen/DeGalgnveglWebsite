using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text.RegularExpressions;
using BotDetect.Web.UI.Mvc;
//using WebSite_Galgnvegl.Models.SharedModel;

namespace WebSite_Galgnvegl.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        Models.SharedModel model = new Models.SharedModel();
   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactIndex()
        {
           
            ViewBag.Message = "Kontaktiere uns:";
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        //[CaptchaValidation("CaptchaCode", "SampleCaptcha", "Incorrect CAPTCHA code!")]
        public ActionResult SendEMail(string Mail_Subject, string Mail_Message, string Mail_Name, string Mail_Tel, string Mail_To, string CaptchaCode, string vcid)
        {
            
            string errormessage;
            List<string> validation = new List<string>();
            //bool isHuman = sampleCaptcha.Validate(CaptchaCode)
            model.isHuman = model.myCaptcha.Validate(CaptchaCode, vcid);

            if (!model.isHuman)
            {
                WebSite_Galgnvegl.Models.Result CaptchaError = new Models.Result(false, "Bot");
                return Json(CaptchaError, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (String.IsNullOrWhiteSpace(Mail_Subject))
                {
                    validation.Add("EmptySubject");
                }
                if (String.IsNullOrWhiteSpace(Mail_Message))
                {
                    validation.Add("EmptyMessage");
                }
                if (String.IsNullOrWhiteSpace(Mail_Name))
                {
                    validation.Add("EmptyName");
                }
                if (String.IsNullOrWhiteSpace(Mail_To))
                {
                    validation.Add("EmptyMailAdress");
                }
                else
                {   //MailValidation
                    bool IsValid = Regex.IsMatch(Mail_To, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    if (!IsValid)
                    {
                        validation.Add("WrongMailAdress");
                    }
                }

                MailMessage mail = new MailMessage();

                errormessage = string.Join(",", validation);

                //CaptchaValidation
                //if (ModelState.IsValid)
                //{
                //    WebSite_Galgnvegl.Models.Result CaptchaError = new Models.Result(false, "Bitte fülle das Captcha aus.");
                //    return Json(CaptchaError, JsonRequestBehavior.AllowGet);
                //}
                //else
                //{
                if (!string.IsNullOrWhiteSpace(errormessage))
                {
                    WebSite_Galgnvegl.Models.Result result = new Models.Result(false, errormessage);
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                else
                {

                    mail.From = new MailAddress(Mail_To);
                    mail.To.Add("DeGalgnvegl@gmail.com");
                    mail.Subject = Mail_Subject;
                    if (Mail_Tel == "")
                    {
                        mail.Body = "E-Mail-Adresse: " + Mail_To + "\n" + "Name: " + Mail_Name + "\n" + "Telefon: Nicht angegeben" + "\n" + "Datum: " + DateTime.Now + "\n\n\n" + "Nachricht:\n" + Mail_Message;
                    }
                    else
                    {
                        mail.Body = "E-Mail-Adresse: " + Mail_To + "\n" + "Name: " + Mail_Name + "\n" + "Telefon: " + Mail_Tel + "\n" + "Datum: " + DateTime.Now + "\n\n\n" + "Nachricht:\n" + Mail_Message;
                    }

                    SmtpClient Smtpclient = new SmtpClient("smtp.gmail.com", 587);

                    try
                    {
                        Smtpclient.Credentials = new System.Net.NetworkCredential("DeGalgnvegl@gmail.com", "Galgnvogl");        //Anmeldung am SMTP-Server
                        Smtpclient.EnableSsl = true;                            //SSL Verschlüsselung erlauben                
                        Smtpclient.Send(mail);                                  //Senden der E-Mail

                        WebSite_Galgnvegl.Models.Result result = new Models.Result(true, "E-Mail wurde versendet.");

                        return Json(result, JsonRequestBehavior.AllowGet);
                    }
                    catch
                    {
                        WebSite_Galgnvegl.Models.Result result = new Models.Result(false, "Fehler beim Versenden der E-Mail");
                        return Json(result, JsonRequestBehavior.AllowGet);

                    }
                }
            }
        }

    }
}
