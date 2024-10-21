using Common.DTOs;
using Data.Entities;
using Data.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            var wines = _wineRepository.GetAllWines();
            return wines.Select(wine => new GetWineDTO
            {
                Name = wine.Name,
                Variety = wine.Variety,
                Year = wine.Year,
                Region = wine.Region,
                Stock = wine.Stock

            }).ToList();
        }

        public List<GetStockDTO> GetStockByVariety(string variety)
        {
            // Llamamos al método del repositorio para obtener los vinos filtrados
            var wines = _wineRepository.GetStockByVariety(variety);

            // Juntamos los vinos por variedad y sumamos el stock para esa variedad
            var stockByVariety = wines
                .GroupBy(wine => wine.Variety)
                .Select(group => new GetStockDTO
                {
                    Variety = group.Key,
                    Stock = group.Sum(wine => wine.Stock)
                })
        .ToList();

            return stockByVariety;
        }
        public void UpdateWineStock(int wineId, UpdateStockWineDTO dto)
        {
            if (dto.Stock < 0)
                throw new ArgumentException("El stock no puede ser negativo");

            _wineRepository.UpdateWineStock(wineId, dto.Stock);
        }


    }
}
