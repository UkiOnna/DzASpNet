using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailSenderDz.App_Start
{
    public class NinjectRegistrator : NinjectModule
    {
        public override void Load()
        {
            Bind<ISender>().To<EmailSender>();
            //Bind<ISender>().To<SmsSender>();
        }
    }
}