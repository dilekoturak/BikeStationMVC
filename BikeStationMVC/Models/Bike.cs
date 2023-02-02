using System;
namespace BikeStationMVC.Models
{
    public class Bike
    {
        public string bike_id { get; set; }
        public string station_id { get; set; }
        public string name { get; set; }
        public double lon { get; set; } = 0;
        public double lat { get; set; } = 0;
        public int is_reserved { get; set; } = 0;
        public int is_disabled { get; set; } = 0;
    }
}

