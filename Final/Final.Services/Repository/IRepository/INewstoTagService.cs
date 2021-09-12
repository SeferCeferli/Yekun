using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface INewstoTagService
    {
        List<NewsToTag> GetNewsTags();
        NewsToTag GetNewsTag(int? id);
        NewsToTag CreateNewsTags(NewsToTag model);
        NewsToTag UpdateNewsTags(NewsToTag model);
        bool DeleteNewsTags(int id);
    }
}
