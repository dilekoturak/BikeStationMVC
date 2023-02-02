using System;
using BikeStationMVC.Interfaces;
using BikeStationMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeStationMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationFileService _stationFileService;
        private readonly IBikeFileService _bikeFileService;

        private readonly string stationFilePath = "wwwroot/json/station.json";
        private readonly string bikeFilePath = "wwwroot/json/bike.json";

        public StationController(IStationFileService stationFileService, IBikeFileService bikeFileService)
        {
            _stationFileService = stationFileService;
            _bikeFileService = bikeFileService;
        }

        [HttpGet("stationList")]
        public IActionResult GetStationList()
        {
            StationList _stationList = _stationFileService.GetAll(stationFilePath);

            return Ok(_stationList.data);
        }

        [HttpGet("stationStatus")]
        public IActionResult GetStationStatus()
        {
            var stationStatusList = new List<StationStatus>();
            StationList _stationList = _stationFileService.GetAll(stationFilePath);
            BikeList _bikeList = _bikeFileService.GetAll(bikeFilePath);

            var stations = _stationList.data.stations;
            var bikes = _bikeList.data.bikes;

            foreach(var station in stations)
            {
                if (station.station_id != null)
                {
                    var stationStatus = new StationStatus();
                    stationStatus.y = bikes.Where(t => t.station_id == station.station_id).Count();
                    stationStatus.name = station.name;
                    stationStatusList.Add(stationStatus);
                }
            }

            return Ok(stationStatusList);
        }
    }
}

