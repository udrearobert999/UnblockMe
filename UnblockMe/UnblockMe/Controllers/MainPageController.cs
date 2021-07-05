﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Data;
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

            var findPartialLPlates = _dbContext.Cars.Where(lp => lp.LicensePlate.Contains(licensePlate)||licensePlate==null).ToList();
            foreach (var item in findPartialLPlates)
                item.Owner = _dbContext.Users.Find(item.OwnerId);
            return View(findPartialLPlates);
        }
    }
}
