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

        public VcFooter(ISocialService socail,ISettingsService settings,ITagsService tagsService)
        {
            _socail = socail;
            _settings = settings;
            _tagsService = tagsService;
        }
        public IViewComponentResult Invoke()
        {
            VmFooter model=new VmFooter()
            {
                Settings=_settings.GetSettings(),
                Socials=_socail.GetSocials(),
                Tags=_tagsService.GetTags()

            };
            return View(model);
        }
    }
}
