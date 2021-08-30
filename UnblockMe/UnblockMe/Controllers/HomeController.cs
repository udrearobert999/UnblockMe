using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{

    [Authorize(Policy = "IsNotBanned")]
    public class HomeController : Controller
    {
        private readonly ICarsService _carsService;
        private readonly INotyfService _notyf;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ICarsService carsService, INotyfService notyf, ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager)
        {
            _carsService = carsService;
            _notyf = notyf;
            _logger = logger;
            _roleManager = roleManager;
        }
    
        public IActionResult Index(string licensePlate)
        {
            if (licensePlate == null)
                return View(null);

            var findPartialLPlates = _carsService.GetCarsByLicensePlate(licensePlate);

            return View(findPartialLPlates);
        }
    }
}
