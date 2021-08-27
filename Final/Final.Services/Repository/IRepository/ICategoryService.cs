using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int? id);
        Category CreateCategory(Category model);
        Category UpdateCategory(Category model);
        bool DeleteCategory(int id);
    }
}
