using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.DTO;
using DataAccessLayer.Interfaces;

namespace BusinessLogicLayer.Interfaces
{
    public interface IAdvertService
    {
        IAdvertRepository _advertRepository { get; set; }
        AdvertDto GetAdvert(int id);
        List<AdvertDto> GetAllAdverts();
    }
}
