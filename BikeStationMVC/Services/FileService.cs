using System;
using BikeStationMVC.Interfaces;

namespace BikeStationMVC.Services
{
    public class FileService<T>: IFileService<T> where T : class
    {
        public FileService()
        {
        }

        public T GetAll(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

