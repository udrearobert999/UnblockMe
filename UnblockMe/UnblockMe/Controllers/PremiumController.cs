using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using UnblockMe.Dtos;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class PremiumController : Controller
    {
        private readonly ICarsService _carsService;
        private readonly IMapInfoProviderService _mapInfoProvider;
        public PremiumController(ICarsService carsService, IMapInfoProviderService cityInfoProvider)
        {
            _carsService = carsService;
            _mapInfoProvider = cityInfoProvider;
        }
        public IActionResult MapInteractions()
        {
            return View();
        }
        [Route("Premium/CountySearch/{countyName}")]
        public IActionResult CountySearch(string countyName)
        {

            return View("CountySearch", countyName);
        }

        [Authorize(Roles="Admin,Premium")]
        public IActionResult GetCountyRegions(string countyName)
        {
            var regions = _mapInfoProvider.GetCountyRegions(countyName);
            return Json(regions);
        }
        
        [HttpGet]
        [Authorize(Roles = "Admin,Premium")]
        public IActionResult CityInfo([FromQuery]string cityName)
        {
            var city = _mapInfoProvider.GetCityInfo(cityName);
            return View(city);
        }
        [Authorize(Roles = "Admin,Premium")]
        public IActionResult GetBlockingInteraction()
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
            
            return Ok(blockingInteractions);
        }
        public IActionResult GetCarJson()
        {
            var allCars = _carsService.GetActiveCars();
            return Json(allCars);
        }
    }
}
