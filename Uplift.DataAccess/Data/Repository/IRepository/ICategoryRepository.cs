//using Uplift.Models;

//namespace Uplift.DataAccess.Data.Repository.IRepository
//{
//    public interface ICategoryRepository : IRepository<Category>
//    {
//        IEnumerable<SelectListItem> GetCategoryListForDropDown();

//        void Update(Category category);
//    }
//}
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();
        void Update(Category category);
    }
}