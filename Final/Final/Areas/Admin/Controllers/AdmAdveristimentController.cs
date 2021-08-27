using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdmAdveristimentController : Controller
    {
        private readonly IAdvertismentService _advertismentService;

        public AdmAdveristimentController(IAdvertismentService advertismentService)
        {
            _advertismentService = advertismentService;
        }

        public IActionResult Index()
        {
            return View(_advertismentService.GetAdvertisments());
        }
        public IActionResult Update(int? AdvertismentId)
        {
            if (AdvertismentId == null && AdvertismentId < 0)
            {
                return NotFound();
            }

            return View(_advertismentService.GetAdvertisment(AdvertismentId));
        }
        [HttpPost]
        public IActionResult Update(Advertisment model)
        {
            if (ModelState.IsValid)
            {
                _advertismentService.UpdateAdvertisment(model);
                return RedirectToAction("Index", "AdmAdveristiment");
            }

            return View(model);
        }
    }
}
