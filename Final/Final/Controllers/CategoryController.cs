using Final.Models;
using Final.Services;
using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ITagsService _tags;
        private readonly ISocialService _socialService;
        private readonly ICategoryService _categoryService;
        private readonly AppDbContext _context;

        public CategoryController(INewsService newsService,ISubscribeService subscribe,ITagsService tags,ISocialService socialService,ICategoryService categoryService,AppDbContext context)
        {
            _newsService = newsService;
            _subscribe = subscribe;
            _tags = tags;
            _socialService = socialService;
            _categoryService = categoryService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string Newssearch)
        {
            ViewData["GetNewsDetails"] = Newssearch;
            var newquery = from x in _context.News select x;
            if (!String.IsNullOrEmpty(Newssearch))
            {
                newquery = newquery.Where(x => x.Title.Contains(Newssearch) || x.Category.Name.Contains(Newssearch)||x.newsToTags.FirstOrDefault().Tags.Name.Contains(Newssearch));
               
            }
            return View(await newquery.AsNoTracking().ToListAsync());
        }

        public IActionResult Category(int categoryId,int page=1)
        {
            List<News> news1 = _newsService.GetNewsbyCategory(categoryId);
            decimal dataPage = 12;
            int pageCount =(int) Math.Ceiling(news1.Count / dataPage);
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            ViewBag.Active = page;

            VmNews news = new VmNews()
            {
                news = news1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList(),
                news4=_newsService.GetNews(),
                categories = _categoryService.GetCategories(),
                socials = _socialService.GetSocials(),
                subscribe = _subscribe.GetSubscribe()
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
            return RedirectToAction(Convert.ToString(model.news2.Category.Name), "Category");
        }
        public IActionResult Details(int newsid )
        {
            News dbnews = _newsService.GetNews(newsid);
            dbnews.ViewCount++;
            _newsService.UpdateNews(dbnews);
            
            VmNews news = new VmNews()
            {

                news2 = dbnews,
                news = _newsService.GetNews(),
                Tags = _tags.GetTags(),
                categories = _categoryService.GetCategories(),
                socials=_socialService.GetSocials(),
                subscribe = _subscribe.GetSubscribe()
            };
            return View(news);
        }

    }
}
