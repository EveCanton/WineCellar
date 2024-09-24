using Data.Entities;
using Data.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WineService : IWineService
    {
        private static List<Wine> wines = new List<Wine>
    {
        new Wine { Id = 1, Name = "Luigi Bosca", Variety = "Cabernet Sauvignon", Region= "Mendoza", Stock= 30, Year= 1901, CreatedAt = new DateTime(2024, 9, 20)},
        new Wine { Id = 2, Name = "Rutini", Variety = "Malbec", Region= "Mendoza", Stock= 10, Year= 1885, CreatedAt = new DateTime(2024, 9, 20)}
    };
        public List<Wine> GetWines()
        {
            return wines;
        }


        public Wine CreateWine(CreateWineDTO dto)
        {
            Wine newWine = new Wine()
            {
                Name = dto.Name,
                Variety = dto.Variety,
                Region = dto.Region,
                Stock = dto.Stock,
                Year = dto.Year
            };
            wines.Add(newWine);
            return newWine;
        }

        public List<GetWineAndStockDTO> GetAllWineAndStock()
        {
            return wines.Select(wine => new GetWineAndStockDTO
            {
                Name = wine.Name,
                Stock = wine.Stock
            }).ToList();
        }
    }
}
