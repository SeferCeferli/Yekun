using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class AdvertismentService : IAdvertismentService
    {
        private readonly AppDbContext _context;

        public AdvertismentService(AppDbContext context)
        {
            _context = context;
        }
        public Advertisment GetAdvertisment(int? id)
        {
            return _context.Advertisment.Find(id);
        }

        public List<Advertisment> GetAdvertisments()
        {
            return _context.Advertisment.ToList();
        }

        public Advertisment UpdateAdvertisment(Advertisment model)
        {
            _context.Advertisment.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
