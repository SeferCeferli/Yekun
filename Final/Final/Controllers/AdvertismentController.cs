using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class AdvertismentController : Controller
    {
        private readonly IAdvertismentService _advertismentService;

        public AdvertismentController(IAdvertismentService advertismentService)
        {
            _advertismentService = advertismentService;
        }
        public IActionResult Index()
        {
            return View(_advertismentService.GetAdvertisments());
        }
    }
}
