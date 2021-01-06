using Blogs.DB;
using System.Collections.Generic;

namespace Blogs.Core
{
    public interface IBlogsServices
    {
        // Get all blogs data.
        List<Blog> GetBlogs();

        //  Returns selected blog.
        Blog GetBlog(int id);

        // Create new Blog.
        Blog CreateBlog(Blog blog);

        // Delete blog. (If there are defined categories, they will also be deleted from BlogCategories table.)
        void DeleteBlog(Blog blog);

        // Update blog.
        Blog EditBlog(Blog blog);
    }
}
