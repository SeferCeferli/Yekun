using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.ViewModels
{
    public class VmNews
    {
        public List<News> news { get; set; }
        public List<News> news4 { get; set; }
        public List<Social> socials { get; set; }
        public List<Category> categories { get; set; }
        public List<Tags> Tags { get; set; }
        public Subscribe subscribe { get; set; }
        public News news2 { get; set; }


    }
}
