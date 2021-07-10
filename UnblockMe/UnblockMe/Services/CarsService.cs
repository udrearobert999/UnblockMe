using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace UnblockMe.Services
{
    public class CarsService : ICarsService
    {
        private readonly UnblockMeContext _dbContext;
        public CarsService(UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Cars> GetCarsList()
        {
            return _dbContext.Cars.ToList();
        }
        public List<Cars> GetCarsByLicensePlate(string licensePlate)
        {
            return _dbContext.Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();
        }
        public void AddCar(Cars car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }
    }

    public interface ICarsService
    {
        public void AddCar(Cars car);
        public List<Cars> GetCarsList();
        public List<Cars> GetCarsByLicensePlate(string licensePlate);
    }
}
