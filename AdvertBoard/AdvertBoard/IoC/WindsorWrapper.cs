using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using Castle.Core;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;

namespace AdvertBoard.IoC
{
    public static class WindsorWrapper
    {
        public static WindsorContainer Container = new WindsorContainer();
    
        public static void Init()
        {
            Container.Register(
                Castle.MicroKernel.Registration.Component.For<IAdvertService>().ImplementedBy<AdvertService>()
                .LifestyleSingleton());

            Container.Register(
                Castle.MicroKernel.Registration.Component.For<IAdvertRepository>().ImplementedBy<AdvertRepository>()
                .LifestyleTransient());
        }
    }
}
