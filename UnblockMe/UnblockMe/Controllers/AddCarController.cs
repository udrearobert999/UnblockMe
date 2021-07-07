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

namespace UnblockMe.Controllers
{
    public class AddCarController : Controller
    {

        private readonly ILogger<AddCarController> _logger;
        private readonly UnblockMeContext _dbContext;
        private readonly UserManager<Users> userManager;
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
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var CurentUser = _dbContext.Users.Where(u => u.UserName == userName).First();
            car.OwnerId = CurentUser.Id;
            car.Owner = CurentUser;
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
            return View();
        }
    }
}
