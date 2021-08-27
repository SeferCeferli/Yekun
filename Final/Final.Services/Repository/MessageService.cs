using Final.Models;
using Final.Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.Services.Repository
{
    public class MessageService : IMessageService
    {
        private readonly AppDbContext _context;

        public MessageService(AppDbContext context)
        {
            _context = context;
        }
        public Message CreateMessage(Message model)
        {
            _context.Message.Add(model);
            _context.SaveChanges();
            return model;
        }

        public bool DeleteMessage(int id)
        {
            Message message = _context.Message.Find(id);
            _context.Message.Remove(message);
            if (_context.SaveChanges() > 0)
                return true;
            return false;
        }

        public Message GetMessage(int id)
        {
            return _context.Message.Find(id);
        }

        public bool GetMessage(string email)
        {
            return _context.Message.Any(m => m.Email == email);

        }

        public List<Message> GetMessages()
        {
            return _context.Message.ToList();
        }

        public Message UpdateMessage(Message model)
        {
            _context.Message.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
