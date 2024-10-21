using Common.DTOs;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class WineRepository : IWineRepository
    {

        private readonly WineCellarContext _context;

        // Inyectamos el DbContext en el constructor
        public WineRepository(WineCellarContext context)
        {
            _context = context;
        }

        // Método para agregar un wine a la base de datos
        public void AddWine(Wine wine)
        {
            _context.Wines.Add(wine);
            _context.SaveChangesAsync(); // Guardar los cambios en la base de datos
        }

        public List<Wine> GetAllWines()
        {
            return _context.Wines.ToList();
        }

        public List<Wine> GetStockByVariety(string variety)
        {
            // Usamos LINQ para filtrar por variedad y verificar que haya stock disponible
            return _context.Wines
                .Where(w => w.Variety.ToLower() == variety.ToLower() && w.Stock > 0)
                .ToList();
        }
        public void UpdateWineStock(int wineId, int stock)
        {
            // Buscamos el vino por su ID
            var wineToUpdate = _context.Wines.FirstOrDefault(w => w.Id == wineId);

            if (wineToUpdate == null)
                throw new Exception("Vino no encontrado");

            // Actualizamos el stock
            wineToUpdate.Stock = stock;
            _context.SaveChanges();
        }


    }
}
