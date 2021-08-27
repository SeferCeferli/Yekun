using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface IMessageService
    {
        List<Message> GetMessages();
        Message GetMessage(int id);
        bool GetMessage(string email);
        Message CreateMessage(Message model);
        Message UpdateMessage(Message model);
        bool DeleteMessage(int id);
    }
}
