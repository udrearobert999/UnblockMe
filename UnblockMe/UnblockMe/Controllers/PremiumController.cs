using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Controllers
{
    public class PremiumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
