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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnblockMeContext _dbContext;
        private readonly INotyfService _notyf;
        public HomeController(ILogger<HomeController> logger,UnblockMeContext appData, INotyfService notyf)
        {
            _logger = logger;
            _dbContext = appData;
            _notyf = notyf;
       
        }

        
        [HttpGet]
        public IActionResult Index(string licensePlate)
        {
            if (licensePlate == null)
                return View(null);



            var findPartialLPlates = _dbContext
                .Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();

            return View(findPartialLPlates);
        }
    }
}
