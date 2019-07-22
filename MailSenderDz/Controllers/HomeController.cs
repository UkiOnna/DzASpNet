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
        private readonly ISender emailSender;
        private readonly ISender smsSender;

        public HomeController(ISender emailSender, ISender smsSender)
        {
            this.emailSender = emailSender;
            this.smsSender = smsSender;
        }
        public ActionResult Index()
        {
            
            return View();
        }
    }
}