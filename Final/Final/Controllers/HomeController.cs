using Final.Models;
using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISubscribeService _subscribe;

        public HomeController(ISubscribeService subscribe)
        {
            _subscribe = subscribe;
        }

        public IActionResult Index()
        { 
            
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(VmNews model)
        {
            if (ModelState.IsValid)
            {
                
                    _subscribe.CreateSubscribe(model.subscribe);

                
                ModelState.AddModelError("", "This mail is already subscribed");
            }
            return RedirectToAction("Index","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
