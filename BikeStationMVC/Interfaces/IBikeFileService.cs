using System;
using BikeStationMVC.Interfaces;
using BikeStationMVC.Models;

namespace BikeStationMVC
{
    public interface IBikeFileService : IFileService<BikeList>
    {
        Task<bool> AddAsync(Bike bike, string filePath);
    }
}

