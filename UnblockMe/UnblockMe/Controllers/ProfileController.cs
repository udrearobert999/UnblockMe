using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
            var logged_user = _userService.GetLoggedInUser();
            var logged_user_cars = _userService.GetCarsListOfUser(logged_user);
            var other_user = _userService.GetUserById(id);
            var other_user_cars = _userService.GetCarsListOfUser(other_user);
            var model = (logged_user, logged_user_cars, other_user, other_user_cars);
            return View(model);
        
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
         
        [Route("Profile/{id}/photo")]
        public IActionResult GetPhoto(string id)
        {
            var user = _userService.GetUserById(id);
            return File(user.ProfilePicture, MediaTypeNames.Image.Jpeg);
            
        }
    }
}
