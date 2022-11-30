using DoodleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace DoodleProject.Controllers
{
    public class MailController : Controller
    {
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(MailRequest mailRequest)
        //{
        //    MimeMessage mimeMessage = new MimeMessage();
           
        //    MailAddress mailAddressFrom = new MailAddress(mailRequest.Name, mailRequest.SenderMail);
        //    mimeMessage.From.Add(mailAddressFrom);
        //    MailAddress mailAddressTo = new MailAddress("User", mailRequest.ReceiverMail);
        //    mimeMessage.To.Add(mailAddressTo);
        //    mimeMessage.Body=mailRequest.Body;
        //    mimeMessage.Subject=mailRequest.Subject;
        //    mimeMessage.Body=mailRequest.Body;
        //    SmtpClient client= new SmtpClient();
        //    client.Connect("smtp.gmail.com", 587, false);
        //    //client.Authenticate()
        //    client.Disconnect(true);
        //    return View();
        //}


    }
}