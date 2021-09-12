using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class AdmCategoryController : Controller
    {
        private readonly ICategoryService _category;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdmCategoryController(ICategoryService category, IWebHostEnvironment webHostEnvironment) 
        {
            _category = category;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page=1)
        {
            List<Category> categories1 = _category.GetCategories();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(categories1.Count / dataPage);
            List<Category> categories = categories1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            ViewBag.Active = "Category";
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

                if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                    return View(model);
                }
                if (model.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "You can only upload max to 2mb size images");
                    return View(model);
                }


                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }
                model.MainImage = fileName;


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
                if (model.ImageFile!=null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                        return View(model);
                    }
                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max to 2mb size images");
                        return View(model);
                    }
                    string oldfilepath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", model.MainImage);
                    System.IO.File.Delete(oldfilepath);

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.MainImage = fileName;
                }
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
