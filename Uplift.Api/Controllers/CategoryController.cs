using Microsoft.AspNetCore.Mvc;
using Uplift.Models;
using Uplift.Service;

namespace Uplift.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("create-category")]
        public IActionResult Create([FromBody] Category model)
        {
            _categoryService.Create(model);
            return Ok();
        }

        [HttpPost("Get-category")]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }
    }
}
