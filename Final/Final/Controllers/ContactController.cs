using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _message;

        public ContactController(IMessageService message)
        {
            _message = message;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(Message model)
        {
            if (ModelState.IsValid)
            {
                    
                _message.CreateMessage(model);
                
               
            }
            return RedirectToAction("Index","Contact");
        }
    }
}
