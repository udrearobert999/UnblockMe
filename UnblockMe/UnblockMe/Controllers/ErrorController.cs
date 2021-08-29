using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
