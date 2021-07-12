using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IUserService _userService;
        private readonly INotyfService _notyf;
        private readonly ICarsService _carsService;
        public ProfileController(ILogger<ProfileController> logger, INotyfService notyf,IUserService userService,ICarsService carsService)
        {
            _logger = logger;
            _userService = userService;
            _notyf = notyf;
            _carsService = carsService;

        }

        [Route("Profile/{id}")]
        public IActionResult Index(string id)
        {  

            return View(_userService.GetUserById(id));
        
        }

   
        public IActionResult BlockedYouAction(string Contact, string MyPlate,string YourPlate)
        {
            try
            {
                var MyCar = _carsService.GetCarByLicensePlate(MyPlate);
                 var YourCar = _carsService.GetCarByLicensePlate(YourPlate);
                _carsService.CarBlocksCar(MyCar, YourCar);
                return Ok("The user will be Notified");
            }
            catch (Exception e) when ((bool)(e.InnerException?.ToString().Contains("CK_Colision_Cars_Constraint")))
            {
                return BadRequest("Invalid action!");
            }

        }
    
        public IActionResult BlockedMeAction(string Contact, string MyPlate,string YourPlate)
        {
            try
            {
                var MyCar = _carsService.GetCarByLicensePlate(MyPlate);
                var YourCar = _carsService.GetCarByLicensePlate(YourPlate);
                _carsService.CarBlocksCar(YourCar, MyCar);
                return Ok("The user will be Notified");
            }
            catch (Exception e) when ((bool)(e.InnerException?.ToString().Contains("CK_Colision_Cars_Constraint")))
            {
                return BadRequest("Invalid action!");
            }
        }
       
    }
}
