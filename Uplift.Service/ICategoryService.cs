//using Uplift.Models;

//namespace Uplift.Service
//{
//    public interface ICategoryService
//    {
//        void Create(Category category);

//        IEnumerable<Category> GetAllCategories();
//    }     
//}

using Uplift.Models;

namespace Uplift.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(int id);
    }
}