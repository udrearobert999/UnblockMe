using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Controllers
{
    public class AddCarController : Controller
    {

        private readonly ILogger<AddCarController> _logger;
        private readonly UnblockMeContext _dbContext;
        public AddCarController(ILogger<AddCarController> logger, UnblockMeContext appData)
        {
            _logger = logger;
            _dbContext = appData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Index(Cars car)
        {
            _dbContext.Cars.Add(car);
            return View();
        }
    }
}
