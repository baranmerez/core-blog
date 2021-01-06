using Microsoft.AspNetCore.Mvc;
using Blogs.Core;
using Blogs.DB;

namespace core_blog_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogsCategoriesController : ControllerBase
    {
        private IBlogsCategoriesServices _blogsCategoriesServices;

        public BlogsCategoriesController(IBlogsCategoriesServices blogsCategoriesServices)
        {
            _blogsCategoriesServices = blogsCategoriesServices;
        }

        [HttpGet]
        public IActionResult GetAllBlogsCategories()
        {
            return Ok(_blogsCategoriesServices.GetAllBlogsCategories());
        }
        
        [HttpGet("BlogCategories/{id}", Name = "GetBlogCategories")]
        public IActionResult GetBlogCategories(int id)
        {
            return Ok(_blogsCategoriesServices.GetBlogCategories(id));
        }

        [HttpGet("CategoriesBlog/{categoryName}", Name = "GetCategoriesBlog")]
        public IActionResult GetCategoriesBlog(string categoryName)
        {
            return Ok(_blogsCategoriesServices.GetCategoriesBlog(categoryName));
        }

        [HttpPost]
        public IActionResult AddCategoriesOfBlog(BlogsCategories blogsCategories)
        {
            var newBlog = _blogsCategoriesServices.AddCategoriesOfBlog(blogsCategories);
            return CreatedAtRoute("GetAllBlogsCategories", new { newBlog.BlogsId }, newBlog);
        }

        [HttpDelete]
        public IActionResult DeleteCategories (BlogsCategories blogsCategories)
        {
            _blogsCategoriesServices.DeleteCategories(blogsCategories);
            return Ok();
        }

    }
}
