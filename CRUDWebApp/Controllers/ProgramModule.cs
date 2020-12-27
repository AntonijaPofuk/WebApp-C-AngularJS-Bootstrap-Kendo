using Autofac;
using CRUDWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Controllers
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotification>().As<INotificationService>();
            builder.RegisterType<UserServices>().AsSelf(); //doesnt implement interface

        }
    }

   
}
