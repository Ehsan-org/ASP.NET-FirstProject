using Uplift.Models;
using System.Collections.Generic;

namespace Uplift.Service
{
    public interface ICategoryService
    {
        void Create(Category category);
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }
}
