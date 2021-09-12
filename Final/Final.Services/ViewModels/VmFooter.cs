using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.ViewModels
{
    public class VmFooter
    {
        public Settings Settings { get; set; }
        public List<Social> socials { get; set; }
        public List<Tags> Tags { get; set; }
        public List<News> news { get; set; }
        public List<Category> categories { get; set; }
    }
}
