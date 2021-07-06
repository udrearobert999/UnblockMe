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
        public MainPageController(ILogger<MainPageController> logger,UnblockMeContext appData)
        {
            _logger = logger;
            _dbContext = appData;
       
        }
        
        public IActionResult Index()
        {

            return View();
        }      

        [HttpGet]
        public IActionResult Index(string licensePlate)
        {

            var findPartialLPlates = _dbContext
                .Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate) || licensePlate == null)
                .ToList();

            return View(findPartialLPlates);
        }
    }
}
