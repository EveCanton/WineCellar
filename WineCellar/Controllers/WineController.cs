using Common.DTOs;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;

namespace WineCellar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;

        // Inyectamos el servicio mediante el constructor
        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [HttpPost]
        public IActionResult CreateWine([FromBody] CreateWineDTO dto)
        {
            _wineService.CreateWine(dto);
            return Ok(dto);
        }

        [HttpGet]
        public IActionResult GetAllWine()
        {
            var wines = _wineService.GetAllWine();
            return Ok(wines);
        }

        [HttpGet("variety/{variety}")]
        public IActionResult GetStockByVariety(string variety)
        {
            // Llamamos al servicio para obtener el stock de la variedad
            var stock = _wineService.GetStockByVariety(variety);

            if (stock == null || stock.Count == 0)
                return NotFound($"No se encontro stock para ésa variedad: {variety}");

            return Ok(stock);
        }

        [HttpPut("{wineId}/stock")]
        public IActionResult UpdateWineStock(int wineId, [FromBody] UpdateStockWineDTO dto)
        {
            try
            {
                // Llamamos al servicio para actualizar el stock
                _wineService.UpdateWineStock(wineId, dto);
                return NoContent(); // Retornamos 204 No Content si fue exitoso
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message); // Retornamos 404 si no se encontró el vino
            }
        }



    }
}
