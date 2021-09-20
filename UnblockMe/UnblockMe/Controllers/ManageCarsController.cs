using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnblockMe.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using UnblockMe.Services;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System;

namespace UnblockMe.Controllers
{
    [Authorize(Policy = "IsNotBanned")]
    [Authorize]
    public class ManageCarsController : Controller
    {

        private readonly ILogger<ManageCarsController> _logger;
        private readonly IUserService _userService;
        private readonly ICarsService _carsService;
        private readonly IBlockingInfoService _blockingInfoService;
        public ManageCarsController(ILogger<ManageCarsController> logger,
                                    IUserService userService,
                                    ICarsService carsService,
                                    IBlockingInfoService blockingInfoService)
        {
            _logger = logger;
            _carsService = carsService;
            _userService = userService;
            _blockingInfoService = blockingInfoService;
        }


        public IActionResult Index()
        {

            var logged_user = _userService.GetLoggedInUser();
            var logged_user_cars =_userService.GetCarsListOfUser(logged_user);

          

            return View(logged_user_cars);
        }
        [HttpPost]

        public IActionResult AddCar(string LicensePlate,string Brand,string Color)
        {
            var car = new Cars();
            car.LicensePlate = LicensePlate;
            car.Brand = Brand;
            car.Color = Color;

            var user = _userService.GetLoggedInUser();
            car.OwnerId = user.Id;
            car.Owner = user;
            if (_carsService.AddCar(car))
                return Ok("The car was added succesfully!");
            else
                return BadRequest("Error!");

        }

        public IActionResult GetCarByLicensePlate(string licenseplate)
        {
            if (licenseplate is null )
                return BadRequest("User has no cars!");
            var car = _carsService.GetCarByLicensePlate(licenseplate);
 
            var res = new
            {
                LicensePlate = car.LicensePlate,
                Color = car.Color,
                Brand = car.Brand
                

            };
            return Json(res);
        }

        public IActionResult EditCar(string licensePlate,string color,string brand)
        {
            try
            {
                var car = _carsService.GetCarByLicensePlate(licensePlate);
                _carsService.EditCar(car, color, brand);

                return Ok("Car edited succesfully!");
            }
            catch(Exception e)
            {
                return BadRequest("Something went wrong!");
            }
        }

        public IActionResult RemoveCar(string licensePlate)
        {
            _carsService.RemoveCar(licensePlate);
            return Ok(licensePlate + " removed succesfully");
        }

        [Route("ManageCars/DownloadCarInfo")]
        [Route("ManageCars/DownloadCarInfo/{user_id}")]
        public IActionResult DownloadCarInfo(string user_id=null)
        {
            Users curent_user;
            if (user_id == null)
                curent_user = _userService.GetLoggedInUser();
            else
                curent_user = _userService.GetUserById(user_id);
            var car_list = _userService.GetCarsListOfUser(curent_user);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("LicensePlate,Brand,Color,BlocksCar,BlockedBy");
            foreach(var element in car_list)
            {
                stringBuilder.AppendLine($"{element.LicensePlate},{element.Brand}" +
                    $",{element.Color},{element.BlocksCar},{element.IsBlockedByCar}");
            }
            return File(Encoding.UTF8.GetBytes(stringBuilder.ToString()), "text/csv", "cars.csv");

        }
        public IActionResult ParkCar(string licenseplate,double lat,double lng)
        {
           
            var car = _carsService.GetCarByLicensePlate(licenseplate);
            if (car.IsBlockedByCar != null)
                return BadRequest("This car is blocked!");

            _carsService.ParkCar(car, lat, lng);
            _carsService.FindAndAssignCityToCar(car);
            return Ok("Car parked succesfully!");

        }
        public double GetBlockingChanceOfSpot(double lat, double lng)
        {
            return _blockingInfoService.GetBlockingChanceOfSpot(lat, lng, 1);
        }


    }
}
