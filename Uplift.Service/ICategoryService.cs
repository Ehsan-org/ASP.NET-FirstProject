using Uplift.Models;

namespace Uplift.Service
{
    public interface ICategoryService
    {
        void Create(Category category);

        IEnumerable<Category> GetAllCategories();
    }     
}
