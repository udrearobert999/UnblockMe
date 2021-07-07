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

namespace UnblockMe.Controllers
{
    public class MainPageController : Controller
    {
        private readonly ILogger<MainPageController> _logger;
        private readonly UnblockMeContext _dbContext;
        private readonly INotyfService _notyf;
        public MainPageController(ILogger<MainPageController> logger,UnblockMeContext appData, INotyfService notyf)
        {
            _logger = logger;
            _dbContext = appData;
            _notyf = notyf;
       
        }
   
        public IActionResult Index()
        {

            return View(null);
        }
        
        [HttpGet]
        public IActionResult Index(string licensePlate)
        {
            if (licensePlate == null)
                _notyf.Warning("Please enter a valid plate!");



            var findPartialLPlates = _dbContext
                .Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();

            return View(findPartialLPlates);
        }
    }
}
