﻿using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IUserService _userService;
        private readonly INotyfService _notyf;
        private Users _curentUser;
        public ProfileController(ILogger<ProfileController> logger, INotyfService notyf,IUserService userService)
        {
            _logger = logger;
            _userService = userService;
            _notyf = notyf;

        }

        [Route("Profile/{id}")]
        public IActionResult Index(string id)
        {  

            return View(_userService.GetUserById(id));
        
        }

   
        public void BlockedYouAction(string Contact, string MyPlate,string YourPlate)
        {
       
        }
    
        public void BlockedMeAction(string Contact, string MyPlate,string YourPlate)
        {

         
        }
       
    }
}