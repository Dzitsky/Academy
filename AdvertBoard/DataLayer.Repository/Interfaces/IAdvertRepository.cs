using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IAdvertRepository
    {
        Advert Get(int id);
        List<Advert> GetAllAdverts();
    }

}
