using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uplift.Models;
using Uplift.Service;

namespace Uplift.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService) 
        {
            _categoryService = categoryService;
        }

        [HttpPost("create-category")]
        public IActionResult Create([FromBody] Category model)
        {
            _categoryService.Create(model);
            return Ok();
        }
    }
}
