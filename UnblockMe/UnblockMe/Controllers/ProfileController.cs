using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Mime;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    [Authorize(Policy = "IsNotBanned")]
    public class ProfileController : Controller
    {
      
        private readonly IUserService _userService;
        private readonly IRatingService _ratingService;
        private readonly ICarsService _carsService;
        private readonly IMathService _mathService;
        private readonly IMapInfoProviderService _mapInfoService;

        public ProfileController(IRatingService ratingService, IUserService userService, ICarsService carsService, IMathService mathService, IMapInfoProviderService mapInfoService)
        {

            _userService = userService;
            _ratingService = ratingService;
            _carsService = carsService;
            _mathService = mathService;
            _mapInfoService = mapInfoService;
        }

        [Route("Profile/{id}")]
        public IActionResult Index(string id)
        {
            var logged_user = _userService.GetLoggedInUser();
            var logged_user_cars = _userService.GetCarsListOfUser(logged_user);
            var other_user = _userService.GetUserById(id);
            var other_user_cars = _userService.GetCarsListOfUser(other_user);

            var rating_list = _userService.GetRatingsOfUser(other_user);
            int rating=0;
            if (rating_list != null)
            {
                double k = 2 * (rating_list.Sum(item => item.rating_value) * (double)1.0 / rating_list.Count());
                rating = (int)k;
            }
           

            var model = (logged_user, logged_user_cars, other_user, other_user_cars,rating);

         
           return View(model);
        
        }


        public IActionResult BlockedYouAction(string Contact, string MyPlate,string YourPlate)
        {
            try
            {
                var MyCar = _carsService.GetCarByLicensePlate(MyPlate);
                 var YourCar = _carsService.GetCarByLicensePlate(YourPlate);
                if (!YourCar.lat.HasValue || !YourCar.lng.HasValue)
                    return BadRequest($"{YourCar.LicensePlate} is not parked!");

                if (!MyCar.lat.HasValue || !MyCar.lng.HasValue)
                    return BadRequest($"{MyCar.LicensePlate} is not parked!");

                var distance = _mathService.ClaculateDist(MyCar.lat.GetValueOrDefault(), YourCar.lat.GetValueOrDefault(), MyCar.lng.GetValueOrDefault(), YourCar.lng.GetValueOrDefault());

                if (distance<=0.02)
                {
                    _carsService.CarBlocksCar(MyCar, YourCar); 
                    return Ok("The user will be Notified");
                }
                else
                    return BadRequest("The cars are too far apart!");
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

        [AllowAnonymous]
        [Route("Profile/{id}/photo")]
        public IActionResult GetPhoto(string id)
        {
            var user = _userService.GetUserById(id);
            return File(user.ProfilePicture, MediaTypeNames.Image.Jpeg);
            
        }
        [Route("Profile/RateAction/{id}")]
        public IActionResult RateAction(int rating,string ratingMessage,string id)
        {
            
                double parsedRating = (double)rating * (double)1.0 / 2;

                var logged_user = _userService.GetLoggedInUser();
                var curentRate = new Ratings();
                curentRate.rater_id = logged_user.Id;
                curentRate.rated_id = id;
                curentRate.rating_value = parsedRating;
                curentRate.rating_message = ratingMessage;
                
                _ratingService.AddOrUpdateRate(curentRate);

                return Ok("Rate posted!");
            
        }
        public IActionResult UnblockCar(string yourcarlp)
        {
            var loggedUser = _userService.GetLoggedInUser();
            var mycars = _userService.GetCarsListOfUser(loggedUser);
            var yourCar = _carsService.GetCarByLicensePlate(yourcarlp);
            var blockingCar = mycars.Find(c => c.LicensePlate == yourCar.IsBlockedByCar);
            if (blockingCar == null)
                return BadRequest($"{yourcarlp} isn't blocked by any of your cars!");
            else
            {

                _carsService.UnblockCar(blockingCar, yourCar);
                return Ok("Car unblocked succesfully!");
            }

         
        }
    }
}
