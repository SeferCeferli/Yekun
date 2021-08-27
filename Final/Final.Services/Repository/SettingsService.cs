using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class SettingsService : ISettingsService
    {
        private readonly AppDbContext _context;

        public SettingsService(AppDbContext context)
        {
            _context = context;
        }
        public Settings CreateSettings(Settings model)
        {
            _context.Settings.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteSettings(int id)
        {
            Settings settings = _context.Settings.Find(id);
            _context.Settings.Remove(settings);
            if (_context.SaveChanges() > 0)
                return true;
                return false;
        }

        public Settings GetSettings()
        {
            return _context.Settings.FirstOrDefault();
        }

        public Settings UpdateSettings(Settings model)
        {
            _context.Settings.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
