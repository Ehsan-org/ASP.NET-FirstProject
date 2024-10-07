//using Uplift.DataAccess.Data.Repository.IRepository;
//using Uplift.Models;

//namespace Uplift.Service
//{
//    public class CategoryService : ICategoryService
//    {
//        private readonly IUnitOfWork _unitOfWork;

//        public CategoryService(IUnitOfWork unitOfWork) 
//        {
//            _unitOfWork = unitOfWork;
//        }

//        public void Create(Category model)
//        {
//            _unitOfWork.Category.Add(model);
//            _unitOfWork.Save();
//        }
//        public IEnumerable<Category> GetAllCategories()
//        {
//            return _unitOfWork.Category.GetAll();
//        }
//    }
//}

using Microsoft.EntityFrameworkCore;
using Uplift.DataAccess.Data;
using Uplift.Models;

namespace Uplift.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task CreateCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            var existingCategory = await _context.Categories.FindAsync(category.Id);
            if (existingCategory == null)
            {
                return false;
            }

            existingCategory.Name = category.Name;
            existingCategory.DisplayOrder = category.DisplayOrder;

            _context.Categories.Update(existingCategory);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return false;
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
