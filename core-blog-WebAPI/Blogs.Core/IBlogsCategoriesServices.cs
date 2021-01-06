using Blogs.DB;
using System.Collections.Generic;

namespace Blogs.Core
{
    public interface IBlogsCategoriesServices
    {
        // Get all datas.
        List<BlogsCategories> GetAllBlogsCategories();

        // Returns which categories the selected block has.
        List<BlogsCategories> GetBlogCategories(int id);

        // Returns which blogs the selected category has been defined on.
        List<BlogsCategories> GetCategoriesBlog(string categoryName);

        // Adds new categories to the selected block.
        BlogsCategories AddCategoriesOfBlog(BlogsCategories blogsCategories);

        // Deletes the category defined in the block.
        void DeleteCategories(BlogsCategories blogsCategories);

        // There was no need for editing, as categories can be added and deleted quickly.
    }
}
