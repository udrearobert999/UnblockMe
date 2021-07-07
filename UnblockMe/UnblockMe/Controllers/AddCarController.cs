using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace UnblockMe.Controllers
{
    public class AddCarController : Controller
    {

        private readonly ILogger<AddCarController> _logger;
        private readonly UnblockMeContext _dbContext;
        private readonly INotyfService _notyf;
        public AddCarController(ILogger<AddCarController> logger, UnblockMeContext appData, INotyfService notyf)
        {
            _logger = logger;
            _dbContext = appData;
            _notyf = notyf;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cars car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userName = User.FindFirstValue(ClaimTypes.Name);
                    var CurentUser = _dbContext.Users.Where(u => u.UserName == userName).First();
                    car.OwnerId = CurentUser.Id;
                    car.Owner = CurentUser;
                    _dbContext.Cars.Add(car);
                    _dbContext.SaveChanges();
                    _notyf.Success("Car succesfully added!");
                }
            }
            catch (Exception e) when ((bool)(e.InnerException?.ToString().Contains("PRIMARY KEY")))
            {
                _notyf.Warning("Car already exists ! Try another!");
            }
            return View();
        }
    }
}
