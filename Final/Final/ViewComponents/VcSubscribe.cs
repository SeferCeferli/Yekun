using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.ViewComponents
{
    public class VcSubscribe:ViewComponent
    {
        public   IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
