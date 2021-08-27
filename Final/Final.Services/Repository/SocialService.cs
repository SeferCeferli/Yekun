using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class SocialService : ISocialService
    {
        private readonly AppDbContext _context;

        public SocialService(AppDbContext context)
        {
            _context = context;
        }
        public Social CreateSocial(Social model)
        {
            _context.Socials.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteSocial(int id)
        {
            Social social = _context.Socials.Find(id);
            _context.Socials.Remove(social);
            if (_context.SaveChanges() > 0)
                return true;
                return false;
        }

        public Social GetSocial(int id)
        {
            return _context.Socials.Find(id);
        }

        public List<Social> GetSocials()
        {
            return _context.Socials.ToList();
        }

        public Social UpdateSocial(Social model)
        {
            _context.Socials.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
