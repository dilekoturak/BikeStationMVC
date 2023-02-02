using System;
namespace BikeStationMVC.Models
{
    public class BikeList
    {
        public double last_updated { get; set; }
        public int ttl { get; set; }
        public Bikes data { get; set; }
    }

    public class Bikes
    {
        public List<Bike> bikes { get; set; }
    }
}

