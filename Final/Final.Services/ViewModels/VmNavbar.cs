using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.ViewModels
{
    public class VmNavbar
    {
        public Subscribe subscribe { get; set; }
        public Category Categories { get; set; }
        public News news { get; set; }
        public List<News> news2 { get; set; }
    }
}
