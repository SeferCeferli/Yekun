using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class AdmNewsController : Controller
    {
        private readonly INewsService _news;
        private readonly ICategoryService _category;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdmNewsController(INewsService news,ICategoryService category, IWebHostEnvironment webHostEnvironment)
        {
            _news = news;
            _category = category;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page=1)
        {
            List<News> news1 = _news.GetNews();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(news1.Count/dataPage);
            List<News> news = news1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = news1.Count;


            return View(news);
        }

        public IActionResult Create()
        {
            ViewBag.Category = _category.GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(News model)
        {
            if (ModelState.IsValid)
            {
                if (!(model.ImageFile.ContentType =="image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                if (model.ImageFile.Length> 2097152)
                {
                    ModelState.AddModelError("", "you can only upload max to 2mb size images");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                string fileName = Guid.NewGuid()+ "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images",fileName);
                using (var stream=new FileStream(filePath,FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }
                model.MainImage = fileName;

                if (!(model.Image1File.ContentType == "image/png" || model.Image1File.ContentType == "image/jpeg" || model.Image1File.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                if (model.Image1File.Length > 2097152)
                {
                    ModelState.AddModelError("", "you can only upload max to 2mb size images");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                string fileName1 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.Image1File.FileName;
                string filePath1 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName1);
                using (var stream = new FileStream(filePath1, FileMode.Create))
                {
                    model.Image1File.CopyTo(stream);
                }
                model.Image1 = fileName1;

                if (!(model.Image2File.ContentType == "image/png" || model.Image2File.ContentType == "image/jpeg" || model.Image2File.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                if (model.Image2File.Length > 2097152)
                {
                    ModelState.AddModelError("", "you can only upload max to 2mb size images");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                string fileName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.Image2File.FileName;
                string filePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName2);
                using (var stream = new FileStream(filePath2, FileMode.Create))
                {
                    model.Image2File.CopyTo(stream);
                }
                model.Image2 = fileName2;
                if (!(model.VideoImageFile.ContentType == "image/png" || model.VideoImageFile.ContentType == "image/jpeg" || model.VideoImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                if (model.VideoImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "you can only upload max to 2mb size images");
                    ViewBag.Category = _category.GetCategories();
                    return View(model);
                }
                string fileName3 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.VideoImageFile.FileName;
                string filePath3 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName3);
                using (var stream = new FileStream(filePath3, FileMode.Create))
                {
                    model.VideoImageFile.CopyTo(stream);
                }
                model.VideoImage = fileName3;
                model.CreatedDate = DateTime.Now;
                _news.CreateNews(model);
                return RedirectToAction("Index");
            }
            ViewBag.Category = _category.GetCategories();
            return View();
        }
        public IActionResult Update(int? NewsID)
        {
            if (NewsID == null && NewsID <= 0)
            {
                return NotFound();
            }
            
            ViewBag.Category = _category.GetCategories();
            return View(_news.GetNews(NewsID));
        }
        [HttpPost]
        public IActionResult Update(News model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile!=null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "you can only upload max to 2mb size images");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.MainImage = fileName;

                    if (!(model.Image1File.ContentType == "image/png" || model.Image1File.ContentType == "image/jpeg" || model.Image1File.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    if (model.Image1File.Length > 2097152)
                    {
                        ModelState.AddModelError("", "you can only upload max to 2mb size images");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    string fileName1 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.Image1File.FileName;
                    string filePath1 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName1);
                    using (var stream = new FileStream(filePath1, FileMode.Create))
                    {
                        model.Image1File.CopyTo(stream);
                    }
                    model.Image1 = fileName1;

                    if (!(model.Image2File.ContentType == "image/png" || model.Image2File.ContentType == "image/jpeg" || model.Image2File.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    if (model.Image2File.Length > 2097152)
                    {
                        ModelState.AddModelError("", "you can only upload max to 2mb size images");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    string fileName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.Image2File.FileName;
                    string filePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName2);
                    using (var stream = new FileStream(filePath2, FileMode.Create))
                    {
                        model.Image2File.CopyTo(stream);
                    }
                    model.Image2 = fileName2;
                    if (!(model.VideoImageFile.ContentType == "image/png" || model.VideoImageFile.ContentType == "image/jpeg" || model.VideoImageFile.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg,png,gif");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    if (model.VideoImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "you can only upload max to 2mb size images");
                        ViewBag.Category = _category.GetCategories();
                        return View(model);
                    }
                    string fileName3 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "-" + model.VideoImageFile.FileName;
                    string filePath3 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName3);
                    using (var stream = new FileStream(filePath3, FileMode.Create))
                    {
                        model.VideoImageFile.CopyTo(stream);
                    }
                    model.VideoImage = fileName3;
                    _news.UpdateNews(model);
                    return RedirectToAction("Index");
                }
                
            }
            ViewBag.Category = _category.GetCategories();
            return View();
        }
        public IActionResult Delete(int NewsId)
        {
            _news.GetNews(NewsId);
            _news.DeleteNews(NewsId);
            return RedirectToAction("Index", "AdmNews");
        }
    }
}
