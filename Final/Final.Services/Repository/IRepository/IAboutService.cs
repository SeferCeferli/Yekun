using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface IAboutService
    {
        
        About GetAbout(int? id);
        List<About> GetAbouts();
        About UpdateAbout(About model);
    }
}
