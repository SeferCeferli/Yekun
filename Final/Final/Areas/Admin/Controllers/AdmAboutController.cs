using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize]
    public class AdmAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdmAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "About";
            return View(_aboutService.GetAbouts());
        }
        public IActionResult Update(int? AboutId)
        {
            if (AboutId == null && AboutId < 0)
            {
                return NotFound();
            }

            return View(_aboutService.GetAbout(AboutId));
        }
        [HttpPost]
        public IActionResult Update(About model)
        {
            if (ModelState.IsValid)
            {
                _aboutService.UpdateAbout(model);
                return RedirectToAction("Index", "AdmAbout");
            }

            return View(model);
        }
    }
}
