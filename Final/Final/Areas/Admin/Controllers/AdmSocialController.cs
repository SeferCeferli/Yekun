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
    public class AdmSocialController : Controller
    {
        private readonly ISocialService _socailService;

        public AdmSocialController(ISocialService socailService)
        {
            _socailService = socailService;
        }
        public IActionResult Index(int page=1)
        {
            List<Social> socials1 = _socailService.GetSocials();
            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(socials1.Count / dataPage);
            List<Social> socials = socials1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.CurrentPage = page;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = socials1.Count;
            ViewBag.Active = "Social";
            return View(socials);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Social model)
        {
            if (ModelState.IsValid)
            {
                _socailService.CreateSocial(model);
                return RedirectToAction("Index", "AdmSocial");
            }
            return View(model);
        }
        public IActionResult Update(int? SocailId)
        {
            if (SocailId == null && SocailId < 0)
            {
                return NotFound();
            }
            return View(_socailService.GetSocial(SocailId));
        }
        [HttpPost]
        public IActionResult Update(Social model)
        {
            if (ModelState.IsValid)
            {
                _socailService.UpdateSocial(model);
                return RedirectToAction("Index", "AdmSocial");
            }
            return View();
        }
        public IActionResult Delete(int SocailId)
        {
            _socailService.GetSocial(SocailId);
            _socailService.DeleteSocial(SocailId);
            return RedirectToAction("Index", "AdmSocial");
        }
    }
}
