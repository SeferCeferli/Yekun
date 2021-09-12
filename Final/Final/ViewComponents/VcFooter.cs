using Final.Services;
using Final.Services.Repository.IRepository;
using Final.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewComponents
{
    public class VcFooter:ViewComponent
    {
        private readonly ISocialService _socail;
        private readonly ISettingsService _settings;
        private readonly ITagsService _tagsService;
        private readonly INewsService _news;

        public VcFooter(ISocialService socail,ISettingsService settings,ITagsService tagsService,INewsService news)
        {
            _socail = socail;
            _settings = settings;
            _tagsService = tagsService;
            _news = news;
        }
        public IViewComponentResult Invoke()
        {
            VmFooter model=new VmFooter()
            {
                Settings=_settings.GetSettings(),
                socials = _socail.GetSocials(),
                Tags=_tagsService.GetTags(),
                news=_news.GetNews()

            };
            return View(model);
        }
    }
}
