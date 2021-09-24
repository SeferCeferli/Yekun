using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewComponents
{
    public class VcNavbar:ViewComponent
    {
        private readonly ISocialService _socail;
        private readonly ISettingsService _settings;
        private readonly ITagsService _tagsService;
        private readonly INewsService _news;

        public VcNavbar(ISocialService socail, ISettingsService settings, ITagsService tagsService, INewsService news)
        {
            _socail = socail;
            _settings = settings;
            _tagsService = tagsService;
            _news = news;
        }
        public IViewComponentResult Invoke()
        {
            VmFooter model = new VmFooter()
            {
                Settings = _settings.GetSettings(),
                socials = _socail.GetSocials(),

            };
            return View(model);
        }
    }
}
