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
    [Area("Admin"), Authorize]
    public class AdmTagsController : Controller
    {
        private readonly ITagsService _tagsService;
        private readonly INewsService _newsService;

        public AdmTagsController(ITagsService tagsService,INewsService newsService)
        {
            _tagsService = tagsService;
            _newsService = newsService;
        }
        public IActionResult Index(int page=1)
        {
            List<Tags> tags1 = _tagsService.GetTags();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(tags1.Count / dataPage);
            List<Tags> tags = tags1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = tags1.Count;
            ViewBag.Active = "Tags";
            return View(tags);
        }
        public IActionResult Create()
        {
            ViewBag.News = _newsService.GetNews();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tags model)
        {
            if (ModelState.IsValid)
            {
                _tagsService.CreateTags(model);
                return RedirectToAction("Index", "AdmTags");
            }
            return View(model);
        }
        public IActionResult Update(int? TagsId)
        {
            if (TagsId == null && TagsId < 0)
            {
                return NotFound();
            }
            return View(_tagsService.GetTag(TagsId));
        }
        [HttpPost]
        public IActionResult Update(Tags model)
        {
            if (ModelState.IsValid)
            {
                _tagsService.UpdateTags(model);
                return RedirectToAction("Index", "AdmTags");
            }
            return View();
        }
        public IActionResult Delete(int TagsId)
        {
            _tagsService.GetTag(TagsId);
            _tagsService.DeleteTags(TagsId);
            return RedirectToAction("Index", "AdmTags");
        }
    }
}
