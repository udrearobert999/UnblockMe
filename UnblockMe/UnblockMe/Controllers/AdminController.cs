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
        private readonly ICarsService _carsService;

        public AdminController(IUserService userService, ICarsService carsService)
        {
            _userService = userService;
            _carsService = carsService;
        }

        [Authorize(Roles="Admin")]
        public IActionResult EditDatabase()
        {
            var users = _userService.GetActiveUsers();
            var cars = _carsService.GetActiveCars();
            users = users.GetRange(0, Math.Min(users.Count(), 20));
            cars = cars.GetRange(0, Math.Min(cars.Count(), 20));
            return View((users,cars));
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

        [Authorize(Roles = "Admin")]
        public PartialViewResult GetPartialUsers(string userName)
        {
            var users = _userService.GetUsersByUserName(userName);
            return PartialView("PartialUsers",users);
        }
        [Authorize(Roles = "Admin")]
        public PartialViewResult GetPartialCars(string licensePlate)
        {
            var cars = _carsService.GetCarsByLicensePlate(licensePlate);
            return PartialView("PartialCars", cars);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult BanUser(string id,string reason,string duration)
        {
            reason = "banned";
            var days = 1;
            var user = _userService.GetUserById(id);
            _userService.BanUser(user,reason,days);
            return Ok("User Banned");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult UnBanUser(string id)
        {

            var user = _userService.GetUserById(id);
            _userService.UnbanUser(user);
            return Ok("User UnBanned");
        }
       
    }
}
