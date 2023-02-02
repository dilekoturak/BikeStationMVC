using System;
namespace BikeStationMVC.Models
{
    public class StationList
    {
        public double last_updated { get; set; }
        public int ttl { get; set; }
        public Stations data { get; set; }
    }

    public class Stations
    {
        public List<Station> stations { get; set; }
    }
}

