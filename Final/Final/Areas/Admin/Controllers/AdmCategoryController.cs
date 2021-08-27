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
    public class AdmCategoryController : Controller
    {
        private readonly ICategoryService _category;

        public AdmCategoryController(ICategoryService category)
        {
            _category = category;
        }
        public IActionResult Index(int page=1)
        {
            List<Category> categories1 = _category.GetCategories();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(categories1.Count / dataPage);
            List<Category> categories = categories1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _category.CreateCategory(model);
                return RedirectToAction("Index", "AdmCategory");
            }
            
            return View();
        }
        public IActionResult Update(int? CategoryId)
        {
            if (CategoryId==null && CategoryId<0)
            {
                return NotFound();
            }
            
            return View(_category.GetCategory(CategoryId));
        }
        [HttpPost]
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                _category.UpdateCategory(model);
                return RedirectToAction("Index", "AdmCategory");
            }

            return View();
        }
        public IActionResult Delete(int CategoryId)
        {
            _category.GetCategory(CategoryId);
            _category.DeleteCategory(CategoryId);
            return RedirectToAction("Index","AdmCategory");
        }
    }
}
