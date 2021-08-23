using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize(Roles="Admin")]
        public IActionResult EditDatabase()
        {
            var users = _userService.GetActiveUsers();
            users = users.GetRange(0, Math.Min(users.Count(), 6));
            return View(users);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GetUser(string id )
        {
            var user = _userService.GetUserById(id);
            var data = new { user.Id, user.FirstName, user.LastName, user.Email, user.PhoneNumber };
            return Json(data);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult updateUser(Users user)
        {
            var real_user = _userService.GetUserById(user.Id);
            real_user.FirstName = user.FirstName;
            real_user.LastName = user.LastName;
            real_user.PhoneNumber = user.PhoneNumber;
            real_user.Email = real_user.UserName = user.Email;
            _userService.AddOrUpdateUser(real_user);
            return Ok("User Updated!");
        }
    }
}
