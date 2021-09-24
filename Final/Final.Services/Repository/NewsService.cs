using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class NewsService : INewsService
    {
        private readonly AppDbContext _context;

        public NewsService(AppDbContext context)
        {
            _context = context;
        }
        public News CreateNews(News model)
        {
            _context.News.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteNews(int id)
        {
            News news = _context.News.Find(id);
            _context.News.Remove(news);
            if (_context.SaveChanges() > 0)
                return true;
            return false;
        }

        public List<News> GetNews()
        {
            return _context.News.Include(c=>c.Category).Include(n => n.newsToTags).ThenInclude(t => t.Tags).ToList();
        }

        public News GetNews(int? id)
        {
            return _context.News.Include(n => n.newsToTags).ThenInclude(t => t.Tags).FirstOrDefault(n=>n.Id == id);
        }

        public List<News> GetNewsbyCategory(int? id)
        {
            return _context.Categories.Include(b=>b.News).FirstOrDefault(n=>n.Id==id)?.News.ToList();
        }

        public News UpdateNews(News model)
        {
            _context.News.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
