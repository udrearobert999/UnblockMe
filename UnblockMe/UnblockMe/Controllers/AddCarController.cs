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
using UnblockMe.Services;

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
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cars car)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var user = _userService.GetLoggedInUser();
                    car.OwnerId = user.Id;
                    _carsService.AddCar(car);
                    _notyf.Success("Car succesfully added!");
                }
            }
            catch (Exception e) when ((bool)(e.InnerException?.ToString().Contains("PRIMARY KEY")))
            {
                _notyf.Warning("Car already exists ! Try another or edit!");
            }
            return View();
        }
        public Cars GetCarByLicensePlate(string licenseplate)
        {
            return _carsService.GetCarByLicensePlate(licenseplate);
        }
    }
}
