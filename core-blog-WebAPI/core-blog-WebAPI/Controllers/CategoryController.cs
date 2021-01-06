using Microsoft.AspNetCore.Mvc;
using Blogs.Core;
using Blogs.DB;

namespace core_category_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categorysServices;

        public CategoryController(ICategoryServices categorysServices)
        {
            _categorysServices = categorysServices;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(_categorysServices.GetCategories());
        }

        [HttpGet("{catName}", Name = "GetCategory")]
        public IActionResult GetCategory(string catName)
        {
            return Ok(_categorysServices.GetCategory(catName));
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            var newCategory = _categorysServices.CreateCategory(category);
            return CreatedAtRoute("GetCategory", new { newCategory.CategoryName }, newCategory);

        }

        [HttpDelete]
        public IActionResult DeleteCategory(Category category)
        {
            _categorysServices.DeleteCategory(category);
            return Ok();
        }

    }
}
