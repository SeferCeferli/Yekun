using Final.Models;
using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISubscribeService _subscribe;
        private readonly INewsService _newsService;
        private readonly ICategoryService _categoryService;

        public HomeController(ISubscribeService subscribe,INewsService newsService,ICategoryService categoryService)
        {
            _subscribe = subscribe;
            _newsService = newsService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {


            VmNews news = new VmNews()
            {
                
                news =_newsService.GetNews(),
                categories = _categoryService.GetCategories(),
                subscribe =_subscribe.GetSubscribe()
            };
            return View(news);
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
