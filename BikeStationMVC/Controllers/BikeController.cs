using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BikeStationMVC.Models;
using System.Text.Json.Nodes;
using BikeStationMVC.Interfaces;
using BikeStationMVC.Services;
using Microsoft.Extensions.Logging;

namespace BikeStationMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeFileService _bikeFileService;
        private readonly string filePath = "wwwroot/json/bike.json";

        public BikeController(IBikeFileService bikeFileService)
        {
            _bikeFileService = bikeFileService;
        }

        [HttpGet("bikeList")]
        public IActionResult GetBikeList()
        {
            BikeList _bikeList = _bikeFileService.GetAll(filePath);

            return Ok(_bikeList.data);
        }

        [HttpPost("saveBike")]
        public IActionResult Save([FromBody] Bike bikeData)
        {
            _bikeFileService.AddAsync(bikeData, filePath);

            return Ok(bikeData);
        }
    }
}

