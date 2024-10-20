﻿using Common.DTOs;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IWineService //interfaz para el servicio para el servicio, solo métodos
    {
        //Registrar(lo tomo como crear) nuevos vinos con sus detalles.
        void CreateWine(CreateWineDTO dto);
        //Consultar el inventario actual para ver los vinos disponibles y sus cantidades.
        List<GetWineDTO> GetAllWine();
        List<GetStockDTO> GetStockByVariety(string variety);
        void UpdateWineStock(int wineId, UpdateStockWineDTO dto);
    }
}
