using Data.Entities;
using Data.Models;
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
        Wine CreateWine(CreateWineDTO dto);
        //Consultar el inventario actual para ver los vinos disponibles y sus cantidades.
        List<GetWineAndStockDTO> GetAllWineAndStock();
    }
}
