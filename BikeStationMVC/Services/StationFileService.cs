using System;
using BikeStationMVC.Interfaces;
using BikeStationMVC.Models;
using Newtonsoft.Json;

namespace BikeStationMVC.Services
{
    public class StationFileService : IStationFileService
    {
        public StationFileService()
        {

        }

        public StationList GetAll(string filePath)
        {
            var jsonData = System.IO.File.ReadAllText(filePath);
            StationList stationList = JsonConvert.DeserializeObject<StationList>(jsonData);
            return stationList;
        }
    }
}

