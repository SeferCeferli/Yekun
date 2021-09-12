using Final.Models;
using Final.Services.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class TagsService : ITagsService
    {
        private readonly AppDbContext _context;

        public TagsService(AppDbContext context)
        {
            _context = context;
        }
        public Tags CreateTags(Tags model)
        {
            _context.Tags.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteTags(int id)
        {
            Tags tags = _context.Tags.Find(id);
            _context.Tags.Remove(tags);
            if (_context.SaveChanges() > 0)
                return true;
                return false;
        }

        public Tags GetTag(int? id)
        {
            return _context.Tags.Find(id);
        }

        public List<Tags> GetTags()
        {
            return _context.Tags.ToList();
        }

        public Tags UpdateTags(Tags model)
        {
            _context.Tags.Add(model);
            _context.SaveChanges();
            return model;
        }
    }
}
