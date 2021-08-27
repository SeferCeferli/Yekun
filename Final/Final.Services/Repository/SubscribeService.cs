using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class SubscribeService : ISubscribeService
    {
        private readonly AppDbContext _context;

        public SubscribeService(AppDbContext context)
        {
            _context = context;
        }
        public Subscribe CreateSubscribe(Subscribe model)
        {
            model.CreatedDate = DateTime.Now;
            _context.Subscribes.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteSubscribe(int id)
        {
            Subscribe subscribe = _context.Subscribes.Find(id);
            _context.Subscribes.Remove(subscribe);
            if (_context.SaveChanges() > 0)
                return true;
                return false;
        }

        public Subscribe GetSubscribe()
        {
            return _context.Subscribes.FirstOrDefault();
        }

        public bool GetSubscribe(string email)
        {
            return _context.Subscribes.Any(e => e.Email == email);
        }

        public List<Subscribe> GetSubscribes()
        {
            return _context.Subscribes.ToList();
        }

        public Subscribe UpdateSubscribe(Subscribe model)
        {
            _context.Subscribes.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
