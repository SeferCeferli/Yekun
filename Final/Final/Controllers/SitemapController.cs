using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class SitemapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
