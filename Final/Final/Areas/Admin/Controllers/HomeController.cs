using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = "DashBoard";
            return View();
        }
    }
}
