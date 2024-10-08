﻿using Common.DTOs;
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
    }
}
