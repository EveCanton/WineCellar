using Common.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IWineRepository
    {
        void AddWine(Wine wine);
        List<Wine> GetAllWines();
        List<Wine> GetStockByVariety(string variety);
        void UpdateWineStock(int wineId, int stock);
    }
}
