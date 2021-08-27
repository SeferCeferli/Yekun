using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    public class AdmSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
