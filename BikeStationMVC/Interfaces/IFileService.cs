using System;
namespace BikeStationMVC.Interfaces
{
    public interface IFileService<T> where T : class
    {
        T GetAll(string filePath);
    }
}

