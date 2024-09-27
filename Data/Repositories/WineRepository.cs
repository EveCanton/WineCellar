using Common.DTOs;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class WineRepository : IWineRepository
    {
        private readonly List<Wine> Wines;

        public WineRepository()
        {
            Wines = new List<Wine>();

            Wine wine1 = new Wine()
            {
                Name = "Cabernet Sauvignon",
                Variety = "Tinto",
                Year = 2015,
                Region = "Mendoza",
                Stock = 150
            };
            Wines.Add(wine1);

            Wine wine2 = new Wine()
            {
                Name = "Chardonnay",
                Variety = "Blanco",
                Year = 2018,
                Region = "La Rioja",
                Stock = 200
            };
            Wines.Add(wine2);

            Wine wine3 = new Wine()
            {
                Name = "Malbec",
                Variety = "Tinto",
                Year = 2020,
                Region = "San Juan",
                Stock = 80
            };
            Wines.Add(wine3);
        }
        public void AddWine(Wine wine)
        {
            Wines.Add(wine);
        }

        public List<Wine> GetAllWines()
        {
            return Wines;
        }


    }   
}
