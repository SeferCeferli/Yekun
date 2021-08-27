using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface ISubscribeService
    {
        List<Subscribe> GetSubscribes();
        Subscribe GetSubscribe();
        bool GetSubscribe(string email);
        Subscribe CreateSubscribe(Subscribe model);
        Subscribe UpdateSubscribe(Subscribe model);
        bool DeleteSubscribe(int id);
    }
}
