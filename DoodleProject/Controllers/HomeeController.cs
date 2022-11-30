using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.UI.WebControls;

namespace DoodleProject.Controllers
{
    public class HomeeController : Controller
    {

        Mail email;

        public HomeeController()
        {
            email = new Mail();
        }
        [HttpGet]
        public ActionResult EMailSender()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EMailSender(string sendMailAdress, string subject, string body)
        {
            email.mail(sendMailAdress, subject, body);
            ViewBag.Kontrol = "Başarı İle Mail Gönderildi";
            return View();
        }


    }
}