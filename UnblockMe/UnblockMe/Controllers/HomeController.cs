using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarsService _carsService;
        private readonly INotyfService _notyf;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ICarsService carsService, INotyfService notyf,ILogger<HomeController> logger)
        {
            _carsService = carsService;
            _notyf = notyf;
            _logger = logger;
       
        }

        
        [HttpGet]
        public IActionResult Index(string licensePlate)
        {
            if (licensePlate == null)
                return View(null);

            var findPartialLPlates = _carsService.GetCarsByLicensePlate(licensePlate); 

            return View(findPartialLPlates);
        }
    }
}
