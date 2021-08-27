using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface INewsService
    {
        List<News> GetNews();
        News GetNews(int? id);
        News CreateNews(News model);
        News UpdateNews(News model);
        bool DeleteNews(int id);
    }
}
