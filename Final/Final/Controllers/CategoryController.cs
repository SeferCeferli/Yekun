using Final.Models;
using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class CategoryController : Controller
    {
        private readonly INewsService _newsService;
        private readonly ISubscribeService _subscribe;

        public CategoryController(INewsService newsService,ISubscribeService subscribe)
        {
            _newsService = newsService;
            _subscribe = subscribe;
        }
        public IActionResult Tech()
        {

            VmNews news = new VmNews()
            {
                news = _newsService?.GetNews(),
               
                subscribe=_subscribe.GetSubscribe()
            };
                
            
            return View(news);
        }

        public IActionResult Sports()
        {
            VmNews news = new VmNews()
            {
                news = _newsService?.GetNews(),

                subscribe = _subscribe.GetSubscribe()
            };
            return View(news);
        }
        public IActionResult Fasion()
        {
            VmNews news = new VmNews()
            {
                news = _newsService?.GetNews(),

                subscribe = _subscribe.GetSubscribe()
            };
            return View(news);
        }
        public IActionResult Food()
        {
            VmNews news = new VmNews()
            {
                news = _newsService?.GetNews(),

                subscribe = _subscribe.GetSubscribe()
            };
            return View(news);
        }
        public IActionResult Lifestyle()
        {
            VmNews news = new VmNews()
            {
                news = _newsService?.GetNews(),
            };
            return View(news);
        }
        
        public IActionResult Subscribe(VmNews model)
        {
            if (ModelState.IsValid)
            {

                _subscribe.CreateSubscribe(model.subscribe);


                ModelState.AddModelError("", "This mail is already subscribed");
            }
            return RedirectToAction(Convert.ToString(model.news2.Category.Name), "Category");
        }
        public IActionResult Details(int newsid)
        {
            VmNews news = new VmNews()
            {
                news2 = _newsService.GetNews(newsid),
                subscribe = _subscribe.GetSubscribe()
            };
            return View(news);
        }
    }
}
