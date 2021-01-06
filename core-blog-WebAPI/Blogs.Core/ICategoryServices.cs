using System.Collections.Generic;
using Blogs.DB;

namespace Blogs.Core
{
    public interface ICategoryServices
    {
        // Returns all categories.
        List<Category> GetCategories();

        // Get selected category. (that's actually unnecessary)
        Category GetCategory(string categoryName);

        // Create new Category.
        Category CreateCategory(Category category);

        // Delete Category (It will be deleted from all blogs defined.)
        void DeleteCategory(Category category);

    }
}
