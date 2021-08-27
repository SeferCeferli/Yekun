using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface ITagsService
    {
        List<Tags> GetTags();
        Tags GetTag(int? id);
        Tags CreateTags(Tags model);
        Tags UpdateTags(Tags model);
        bool DeleteTags(int id);
    }
}
