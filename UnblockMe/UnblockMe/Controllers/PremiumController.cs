using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using UnblockMe.Dtos;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    [Authorize(Roles="Admin,Premium")]
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

        public IActionResult GetCountyRegions(string countyName)
        {
            var regions = _mapInfoProvider.GetCountyRegions(countyName);
            return Json(regions);
        }
        
        [HttpGet]
        public IActionResult CityInfo([FromQuery]string cityName)
        {
            var city = _mapInfoProvider.GetCityInfo(cityName);
            return View(city);
        }
        /*public void InitDatabase(string countriesInfo)
        {
            var items = JArray.Parse(countriesInfo);

            int cnt = 0;
            foreach (var element in items)
            {
                var toAdd = new CityInfo();
                toAdd.Id = element.Value<int>("id");
                toAdd.Name= element.Value<string>("nume");
                toAdd.County = element.Value<string>("judet");
                toAdd.Auto = element.Value<string>("auto");
                toAdd.Population = element.Value<int>("populatie");
                toAdd.Latitude = element.Value<double>("lat");
                toAdd.Longitude= element.Value<double>("lng");
                _dbContext.CityInfo.Add(toAdd);
               
                cnt++;
            }
            _dbContext.SaveChanges();


        }*/
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
    }
}
