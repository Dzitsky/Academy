using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Implementations
{
    public class AdvertRepository : IAdvertRepository
    {
        private new List<Advert> _temp;

        public AdvertRepository()
        {
            _temp = new List<Advert>()
            {
                new Advert() {Id = 0, Name = "Объявление 1", Text = "Текст"},
                new Advert() {Id = 1, Name = "Объявление 2", Text = "Текст"},
            };
        }

        public Advert Get(int id)
        {
            return _temp.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Advert> GetAllAdverts()
        {
            return _temp;
        }
    }
}
