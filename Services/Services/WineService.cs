using Common.DTOs;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class WineService : IWineService
    {
        private readonly IWineRepository _wineRepository;
        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }


        public void CreateWine(CreateWineDTO dto)
        {
            Wine newWine = new Wine()
            {
                Name = dto.Name,
                Variety = dto.Variety,
                Region = dto.Region,
                Stock = dto.Stock,
                Year = dto.Year
            };
            
            _wineRepository.AddWine(newWine);
        }

        public List<GetWineDTO> GetAllWine()
        {
            return _wineRepository.GetAllWines().Select(wine => new GetWineDTO()
            {
                Name = wine.Name,
                Variety = wine.Variety,
                Year = wine.Year,
                Region = wine.Region,
                Stock = wine.Stock

            }).ToList();
        }
    }
}
