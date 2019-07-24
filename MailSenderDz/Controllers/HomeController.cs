using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MailSenderDz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly ISender Sender;

        public HomeController(ISender emailSender)
        {
            this.Sender = emailSender;
        }
        public ActionResult Index()
        {
            ViewBag.Message=Sender.Send("Сообщение");
            return View();
        }
    }
}