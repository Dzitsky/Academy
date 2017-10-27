using System.Collections.Generic;
using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;


namespace BusinessLogicLayer.Services
{
    public class AdvertService: IAdvertService
    {
        public IAdvertRepository _advertRepository { get; set; }
    
        public AdvertService(IAdvertRepository advertRepository)
        {
            _advertRepository = advertRepository;
        }
        public AdvertDto GetAdvert(int id)
        {
            //AdvertRepository advertRepository = new AdvertRepository();

            var advert = _advertRepository.Get(id);

            Mapper.Initialize(cfg => cfg.CreateMap<Advert, AdvertDto>());
            var advertDto = Mapper.Map<Advert, AdvertDto>(advert);

            return advertDto;
        }

        public List<AdvertDto> GetAllAdverts()
        {
            //AdvertRepository advertRepository = new AdvertRepository();
            
            Mapper.Initialize(cfg => cfg.CreateMap<Advert, AdvertDto>());
            var advertDtos = Mapper.Map<IEnumerable<Advert>, List<AdvertDto>>(_advertRepository.GetAllAdverts());

            return advertDtos;
        }
    }
}
