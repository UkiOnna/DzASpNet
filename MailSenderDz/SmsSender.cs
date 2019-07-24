using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailSenderDz
{
    public class SmsSender : ISender
    {
        public string Send(string message)
        {
            return "Отправлено sms";
        }
    }
}