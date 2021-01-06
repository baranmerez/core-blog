using Blogs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogs.Core
{
    public class BlogsCategoriesServices : IBlogsCategoriesServices
    {
        private AppDbContext _context;

        public BlogsCategoriesServices(AppDbContext context)
        {
            _context = context;
        }

        public BlogsCategories AddCategoriesOfBlog(BlogsCategories blogsCategories)
        {
            _context.Add(blogsCategories);
            _context.SaveChanges();

            return blogsCategories;
        }

        public void DeleteCategories(BlogsCategories blogsCategories)
        {
            _context.BlogsCategories.Remove(blogsCategories);
            _context.SaveChanges();
        }

        public List<BlogsCategories> GetAllBlogsCategories()
        {
            return _context.BlogsCategories.ToList();
        }

        public List<BlogsCategories> GetBlogCategories(int id)
        {
            return _context.BlogsCategories.Where(e => e.BlogsId == id).ToList();
        }

        public List<BlogsCategories> GetCategoriesBlog(string categoryName)
        {
            return _context.BlogsCategories.Where(e => e.CategoryName == categoryName).ToList();
        }

    }
}
