using Microsoft.AspNetCore.Mvc;
using Blogs.Core;
using Blogs.DB;

namespace core_blog_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogsController : ControllerBase
    {
        private IBlogsServices _blogsServices;

        public BlogsController(IBlogsServices blogsServices)
        {
            _blogsServices = blogsServices;
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            return Ok(_blogsServices.GetBlogs());
        }

        [HttpGet("{id}", Name = "GetBlogs")]
        public IActionResult GetBlogs(int id)
        {
            return Ok(_blogsServices.GetBlog(id));
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog)
        {
            var newBlog = _blogsServices.CreateBlog(blog);
            return CreatedAtRoute("GetBlogs", new { newBlog.BlogsId }, newBlog);
        
        }

        [HttpDelete]
        public IActionResult DeleteBlog(Blog blog)
        {
            _blogsServices.DeleteBlog(blog);
            return Ok();
        }

    }
}
