using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailSenderDz
{
    public class EmailSender : ISender
    {
        public string Send(string message)
        {
            return "Отправлен email";
        }
    }
}