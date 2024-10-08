using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Category model)
        {
            _unitOfWork.Category.Add(model);
            _unitOfWork.Save();
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _unitOfWork.Category.GetAll();
        }
    }
}

