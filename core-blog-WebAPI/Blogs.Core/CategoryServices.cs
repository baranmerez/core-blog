using Blogs.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blogs.Core
{
    public class CategoryServices : ICategoryServices
    {
        private AppDbContext _context;

        public CategoryServices(AppDbContext context)
        {
            _context = context;
        }

        public Category CreateCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();

            return category;
        }

        public void DeleteCategory(Category category)
        {
            

            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(string categoryName)
        {
            return _context.Categories.First(e => e.CategoryName == categoryName);
        }
    }
}
