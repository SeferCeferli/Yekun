using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class NewstoTagService : INewstoTagService
    {
        private readonly AppDbContext _context;

        public NewstoTagService(AppDbContext context)
        {
            _context = context;
        }
        public NewsToTag CreateNewsTags(NewsToTag model)
        {
            _context.newsToTags.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteNewsTags(int id)
        {
            NewsToTag newsToTag = _context.newsToTags.Find();
            _context.newsToTags.Remove(newsToTag);
            if (_context.SaveChanges() > 0)
                return true;
            return false;
        }

        public NewsToTag GetNewsTag(int? id)
        {
            return _context.newsToTags.Find(id);
        }

        public List<NewsToTag> GetNewsTags()
        {
            return _context.newsToTags.ToList();
        }

        public NewsToTag UpdateNewsTags(NewsToTag model)
        {
            _context.newsToTags.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
