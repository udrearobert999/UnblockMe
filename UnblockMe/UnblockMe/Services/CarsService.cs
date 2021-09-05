using System;
using System.Collections.Generic;
using System.Linq;
using UnblockMe.Models;
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

        public List<Cars> GetCarsByLicensePlate(string licensePlate, bool getLoggedUserCars=true)
        {
            var cars = _dbContext.Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate)).ToList();
            cars = cars.GetRange(0, Math.Min(3, cars.Count()));
           

            if (_userService.GetLoggedInUser() != null && getLoggedUserCars)
                cars.RemoveAll(car => car.Owner.Id == _userService.GetLoggedInUser().Id);
            return cars;

        }
        public Cars GetCarByLicensePlate(string licensePlate)
        {
            return _dbContext.Cars.Find(licensePlate);
        }
        public bool AddCar(Cars car)
        {
            try
            {
               
                _dbContext.Cars.Add(car);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception e) when ((bool)(e.InnerException?.ToString().Contains("PRIMARY KEY")))
            {
                return false;
            }

        }

        public void CarBlocksCar(Cars car1, Cars car2)
        {
            car1.BlocksCar = car2.LicensePlate;
            car2.IsBlockedByCar = car1.LicensePlate;
            _dbContext.SaveChanges();

        }
        public void EditCar(Cars car,string color,string brand)
        {
   
            if (car.Color != color)
                car.Color = color;
            if (car.Brand != brand)
                car.Brand = brand;
            _dbContext.SaveChanges();
        }

        public void RemoveCar(string licensePlate)
        {
            if (licensePlate != null)
            {
                _dbContext.Cars.Remove(GetCarByLicensePlate(licensePlate));
                _dbContext.SaveChanges();
            }
        }
        public List<Cars> GetActiveCars()
        {
            return _dbContext.Cars.ToList();
        }
    }

    public interface ICarsService
    {
        public List<Cars> GetActiveCars();
        public void RemoveCar(string licensePlate);
        public void EditCar(Cars car, string color, string brand);
        public void CarBlocksCar(Cars car1, Cars car2);
        public Cars GetCarByLicensePlate(string licensePlate);
        public bool AddCar(Cars car);
        public List<Cars> GetCarsByLicensePlate(string licensePlate, bool getLoggedUserCars = true);
    }
}
