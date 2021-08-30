using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UnblockMe.Models;

namespace UnblockMe.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Banned(banned_users bUser)
        {
            return View(bUser);
        }
    }
}
