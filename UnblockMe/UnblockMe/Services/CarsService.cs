using System;
using System.Collections.Generic;
using System.Linq;
using UnblockMe.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics.CodeAnalysis;

namespace UnblockMe.Services
{
    public class CarsService : ICarsService
    {
        private readonly UnblockMeContext _dbContext;
        private readonly IUserService _userService;
        private readonly IMapInfoProviderService _cityInfoProvider;
        private readonly IMathService _mathService;
        public CarsService(UnblockMeContext dbContext, IUserService userService, IMapInfoProviderService cityInfoProvider, IMathService mathService)
        {
            _dbContext = dbContext;
            _userService = userService;
            _cityInfoProvider = cityInfoProvider;
            _mathService = mathService;
        }

        public List<Cars> GetCarsByLicensePlate(string licensePlate, bool getLoggedUserCars = true)
        {
            var cars = _dbContext.Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();
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
            bool ok = (car2.IsBlockedByCar == null);
            car1.BlocksCar = car2.LicensePlate;
            car2.IsBlockedByCar = car1.LicensePlate;
            if (ok)
                _cityInfoProvider.GetCityById(car2.CityId).BlockedCarsNumber++;
            _dbContext.SaveChanges();

        }
        public void EditCar(Cars car, string color, string brand)
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
            var cars = _dbContext.Cars;
            return _dbContext.Cars.ToList();
        }
        public void ParkCar(Cars car, double lat, double lng)
        {
            car.lat = lat;
            car.lng = lng;
            _dbContext.SaveChanges();
        }

        public void UnblockCar(Cars BlockingCar, Cars CarToUnblock)
        {
            BlockingCar.BlocksCar = null;
            CarToUnblock.IsBlockedByCar = null;
            _cityInfoProvider.GetCityById(CarToUnblock.CityId).BlockedCarsNumber--;
            _dbContext.SaveChanges();
        }
        public void FindAndAssignCityToCar(Cars car)
        {
            var cityList = _cityInfoProvider.GetActiveCities();
            var firstCity = cityList.First();
            var carLat = car.lat.GetValueOrDefault();
            var carLong = car.lng.GetValueOrDefault();
            double minDist = _mathService.ClaculateDist(carLat,
                                                      firstCity.Latitude,
                                                      carLong,
                                                      firstCity.Longitude);
            CityInfo minCity = firstCity;
            foreach(var city in cityList)
            {
                var dist = _mathService.ClaculateDist(carLat,
                                                      city.Latitude,
                                                      carLong,
                                                      city.Longitude);
                if(dist<minDist)
                {
                    minDist = dist;
                    minCity = city;
                }
            }
            if (car.CityId!=minCity.Id)
            {
                car.CityId = minCity.Id;
                minCity.ParkedCarsNumber++;
                _dbContext.SaveChanges();
            }
        }
    }



    public interface ICarsService
    {
        public void FindAndAssignCityToCar(Cars car);
        public void UnblockCar(Cars BlockingCar, Cars CarToUnblock);
        public void ParkCar(Cars car, double lat, double lng);
        public List<Cars> GetActiveCars();
        public void RemoveCar(string licensePlate);
        public void EditCar(Cars car, string color, string brand);
        public void CarBlocksCar(Cars car1, Cars car2);
        public Cars GetCarByLicensePlate(string licensePlate);
        public bool AddCar(Cars car);
        public List<Cars> GetCarsByLicensePlate(string licensePlate, bool getLoggedUserCars = true);
     
    }
}
