using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AdvertBoard.IoC;
using AdvertBoard.Models;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Interfaces;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace AdvertBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorWrapper.Init();

            PrintAllAdverts();
            Console.ReadLine();
        }

        public static void PrintAllAdverts()
        {
            var advertService = WindsorWrapper.Container.Resolve<IAdvertService>();

            var adverts = advertService.GetAllAdverts();

            foreach (var advert in adverts)
            {
                Console.WriteLine("[{0}] Name: {1}, Text: {2}", advert.Id, advert.Name, advert.Text);
            }

            //var advertService2 = WindsorWrapper.Container.Resolve<IAdvertService>();
            //adverts = advertService2.GetAllAdverts();

            //Console.WriteLine(advertService == advertService2);
            //Console.WriteLine(advertService._advertRepository == advertService2._advertRepository);
        }
    }
}
