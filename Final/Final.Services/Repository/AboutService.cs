using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class AboutService : IAboutService
    {
        private readonly AppDbContext _context;

        public AboutService(AppDbContext context)
        {
            _context = context;
        }



        public About GetAbout(int? id)
        {
            return _context.Abouts.Find(id);
        }

        public List<About> GetAbouts()
        {
            return _context.Abouts.ToList();
        }

        public About UpdateAbout(About model)
        {
            _context.Abouts.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
