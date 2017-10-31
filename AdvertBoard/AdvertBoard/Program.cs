using System;
using AdvertBoard.IoC;
using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;

namespace AdvertBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorWrapper.Init();
            Mapper.Initialize(cfg => cfg.CreateMap<Advert, AdvertDto>());
            
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
        }
    }
}
