using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;
using System.Collections.Generic;

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

        public Category GetCategoryById(int id)
        {
            return _unitOfWork.Category.Get(id);
        }

        public bool UpdateCategory(Category category)
        {
            var existingCategory = _unitOfWork.Category.Get(category.Id);
            if (existingCategory == null)
            {
                return false;
            }

            existingCategory.Name = category.Name;
            existingCategory.DisplayOrder = category.DisplayOrder;

            _unitOfWork.Category.Update(existingCategory);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteCategory(int id)
        {
            var category = _unitOfWork.Category.Get(id);
            if (category == null)
            {
                return false;
            }

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            return true;
        }
    }
}

