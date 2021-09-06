using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class PremiumController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICarsService _carsService;

        public PremiumController(IUserService userService, ICarsService carsService)
        {
            _userService = userService;
            _carsService = carsService;
        }
        public class BlockingInteraction
        {
            public BlockingInteraction(string blockedCarLicensePlate, string blockingCarLicensePlate, double blockedCarLat, double blockedCarLng)
            {
                BlockedCarLicensePlate = blockedCarLicensePlate;
                BlockingCarLicensePlate = blockingCarLicensePlate;
                BlockedCarLat = blockedCarLat;
                BlockedCarLng = blockedCarLng;
            }

            public BlockingInteraction()
            {
            }

            public string BlockedCarLicensePlate { get; set; }
            public string BlockingCarLicensePlate { get; set; }
            public double BlockedCarLat { get; set; }
            public double BlockedCarLng { get; set; }
        }
        public IActionResult MapInteractions()
        {
            return View();
        }

        public JsonResult GetBlockingInteraction()
        {
            var allCars = _carsService.GetActiveCars();
            var blockingInteractions = new List<BlockingInteraction>();
            foreach(var car in allCars)
                if (car.IsBlockedByCar != null)
                {
                    var parsedCar = new BlockingInteraction(car.LicensePlate,
                        car.IsBlockedByCar,
                        car.lat.Value,
                        car.lng.Value);
                    blockingInteractions.Add(parsedCar);
                }

            return Json(blockingInteractions);
        }
    }
}
