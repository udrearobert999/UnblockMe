using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;
using UnblockMe.Models;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    [Authorize(Policy = "IsNotBanned")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICarsService _carsService;
        private readonly IRoleService _roleService;

        public AdminController(IUserService userService, ICarsService carsService, IRoleService roleService)
        {
            _userService = userService;
            _carsService = carsService;
            _roleService = roleService;
        }

        [Authorize(Roles="Admin")]
        public IActionResult AdminPanel()
        {
            var users = _userService.GetActiveUsers();
            var cars = _carsService.GetActiveCars();
            users = users.GetRange(0, Math.Min(users.Count(), 20));
            cars = cars.GetRange(0, Math.Min(cars.Count(), 20));
            return View((users,cars));
        }
        
        public IActionResult GetUser(string id )
        {
            var user = _userService.GetUserById(id);
            var data = new { user.Id, user.FirstName, user.LastName, user.Email, user.PhoneNumber };
            return Json(data);
        }
        
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

        
        public PartialViewResult GetPartialUsers(string userName)
        {
            var users = _userService.GetUsersByUserName(userName);
            return PartialView("PartialUsers",users);
        }
        public PartialViewResult GetUserRoles(string id)
        {
            var user = _userService.GetUserById(id);
            var user_roles = _roleService.GetUserRoles(user);
            var allRoles = _roleService.GetAvailableRoles();
            return PartialView("ManageRoles",(allRoles,user_roles,id));
        }
        
        public PartialViewResult GetPartialCars(string licensePlate)
        {
            var cars = _carsService.GetCarsByLicensePlate(licensePlate,false);
            return PartialView("PartialCars", cars);
        }
        
        public IActionResult BanUser(string id,string reason,string duration)
        {
            try
            {
                reason ??= "Unspecified reason but you probably did something!";
                var durationParsed=Int32.Parse(duration);
                var user = _userService.GetUserById(id);
                if (durationParsed == 2)
                    durationParsed = 30;
                else
                    if (durationParsed == 3)
                    durationParsed = 360;
                

                _userService.BanUser(user, reason, durationParsed);
                return Ok("User Banned");
            }
            catch(Exception e)
            {
                if (e.Message.Contains("same key"))
                    return BadRequest("User already banned!");
                else
                    return BadRequest("Something went wrong!");
            }
            
        }
        
        public IActionResult UnBanUser(string id)
        {

            try
            {
                var user = _userService.GetUserById(id);
                _userService.UnbanUser(user);
                return Ok("User UnBanned");
            }
            catch(Exception e)
            {
                if (e.Message.Contains("Value cannot be null"))
                    return BadRequest("User is not banned!");
                else
                    return BadRequest("Something went wrong!");
            }
       
        }
       
        public IActionResult DownloadBanInfoCSV(string id)
        {
            var banInfo = _userService.GetUserBanInfo(id);
        
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Banned By,Reason,Ban Start,Ban End");
            foreach (var banAction in banInfo)
            {
                var user = _userService.GetUserById(banAction.BannedBy);
                stringBuilder.AppendLine($"{user.FirstName + ' ' + user.LastName},{banAction.Reason},"
                    + $"{banAction.BanStart},{banAction.BanEnd}");
            }

            return File(Encoding.UTF8.GetBytes(stringBuilder.ToString()), "text/csv", "baninfo.csv");
        }
        public IActionResult AddUserToRole(string id, string role)
        {
            try
            {
                var user = _userService.GetUserById(id);
                _roleService.AddUserToRole(user, role);

                return Ok("Role assigned successfully");
            }
            catch (Exception e)
            {
                if (e.InnerException.Message.Contains("PRIMARY KEY"))
                    return BadRequest("User already has this role!");
                else
                    return BadRequest("Something went wrong!");
            }
        }
        public IActionResult RemoveUserFromRole(string id, string role)
        {
            try
            {
                var user = _userService.GetUserById(id);
                _roleService.RemoveUserFromRole(user, role);
                return Ok("Role unassigned successfully");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
