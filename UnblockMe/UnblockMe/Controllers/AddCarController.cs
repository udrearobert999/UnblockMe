﻿using Microsoft.AspNetCore.Mvc;
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
using UnblockMe.Services;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace UnblockMe.Controllers
{
    public class AddCarController : Controller
    {

        private readonly ILogger<AddCarController> _logger;
        private readonly IUserService _userService;
        private readonly ICarsService _carsService;
        private readonly INotyfService _notyf;
        public AddCarController(ILogger<AddCarController> logger,
                                IUserService userService,
                                ICarsService carsService,
                                INotyfService notyf)
        {
            _logger = logger;
            _carsService = carsService;
            _userService = userService;
            _notyf = notyf;
        }

        [Authorize]
        public IActionResult Index()
        {

            var logged_user = _userService.GetLoggedInUser();
            var logged_user_cars =_userService.GetCarsListOfUser(logged_user);

          

            return View(logged_user_cars);
        }
        [HttpPost]
        [Authorize]
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
        [Authorize]
        public IActionResult GetCarByLicensePlate(string licenseplate)
        {
            return Json(_carsService.GetCarByLicensePlate(licenseplate));
        }
        [Authorize]
        public IActionResult EditCar(string licensePlate,string color,string brand)
        {
               var car = _carsService.GetCarByLicensePlate(licensePlate);
                _carsService.EditCar(car, color, brand);
            
            return Ok("Car edited succesfully!");
        }
        [Authorize]
        public IActionResult RemoveCar(string licensePlate)
        {
            _carsService.RemoveCar(licensePlate);
            return Ok(licensePlate + " removed succesfully");
        }
        [Authorize]
        public IActionResult DownloadCarInfo()
        {
            var logged_user = _userService.GetLoggedInUser();
            var car_list = _userService.GetCarsListOfUser(logged_user);
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("LicensePlate,Brand,Color,BlocksCar,BlockedBy");
            foreach(var element in car_list)
            {
                stringBuilder.AppendLine($"{element.LicensePlate},{element.Brand}" +
                    $",{element.Color},{element.BlocksCar},{element.IsBlockedByCar}");
            }
            return File(Encoding.UTF8.GetBytes(stringBuilder.ToString()), "text/csv", "cars.csv");

        }
        [Authorize]
        public IActionResult DownloadExcel()
        {
            return Content("EXCEL");
        }
    }
}
