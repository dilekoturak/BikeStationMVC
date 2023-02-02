using BikeStationMVC.Interfaces;
using BikeStationMVC.Models;
using Newtonsoft.Json;

namespace BikeStationMVC
{
    public class BikeFileService : IBikeFileService
    {
        private static readonly JsonSerializerSettings _options = new() { NullValueHandling = NullValueHandling.Ignore };

        public BikeFileService()
        {

        }

        public async Task<bool> AddAsync(Bike bike, string filePath)
        {
            var jsonData = System.IO.File.ReadAllText(filePath);

            BikeList bikeList = JsonConvert.DeserializeObject<BikeList>(jsonData);
            bikeList.last_updated = bikeList.last_updated++;
            bikeList.ttl = bikeList.ttl++;

            var data = bikeList.data;
            data.bikes.Add(bike);

            var jsonString = JsonConvert.SerializeObject(bikeList, _options);
            File.WriteAllText(filePath, jsonString);

            return true;
        }

        public BikeList GetAll(string filePath)
        {
            var jsonData = System.IO.File.ReadAllText(filePath);
            BikeList bikeList = JsonConvert.DeserializeObject<BikeList>(jsonData);

            return bikeList;
        }
    }
}