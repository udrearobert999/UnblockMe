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
        private readonly IUserService _userService;
        public CarsService(UnblockMeContext dbContext, IUserService userService)
        {
            _dbContext = dbContext;
            _userService = userService;
        }
     
        public List<Cars> GetCarsByLicensePlate(string licensePlate)
        {
            var cars = _dbContext.Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();
           
            cars.RemoveAll( car => car.Owner.Id ==_userService.GetLoggedInUser().Id);
            return cars;

        }
        public Cars GetCarByLicensePlate(string licensePlate)
        {
            return _dbContext.Cars.Find(licensePlate);
        }
        public void AddCar(Cars car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }

    public interface ICarsService
    {
        public void Save();
        public Cars GetCarByLicensePlate(string licensePlate);
        public void AddCar(Cars car);
        public List<Cars> GetCarsByLicensePlate(string licensePlate);
    }
}
