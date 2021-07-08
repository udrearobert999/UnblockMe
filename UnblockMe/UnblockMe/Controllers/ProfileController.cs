using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;


namespace UnblockMe.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly UnblockMeContext _dbContext;
        private readonly INotyfService _notyf;
        public ProfileController(ILogger<ProfileController> logger, UnblockMeContext appData, INotyfService notyf)
        {
            _logger = logger;
            _dbContext = appData;
            _notyf = notyf;

        }

        [Route("Profile/{id}")]
        public IActionResult Index(string id)
        {
            var user = _dbContext.Users.Find(id);
            return View(user);
        }
    }
}
