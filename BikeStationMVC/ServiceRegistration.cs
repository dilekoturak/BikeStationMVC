using System;
using BikeStationMVC.Interfaces;
using BikeStationMVC.Services;

namespace BikeStationMVC
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddScoped<IReadFileService, ReadFileService>();
            //services.AddScoped<IWriteFileService, WriteFileService>();
            services.AddScoped<IBikeFileService, BikeFileService>();
            services.AddScoped<IStationFileService, StationFileService>();
        }
    }
}

