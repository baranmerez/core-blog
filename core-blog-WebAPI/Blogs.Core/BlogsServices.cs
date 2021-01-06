using Blogs.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blogs.Core
{
    public class BlogsServices : IBlogsServices
    {
        private AppDbContext _context;

        public BlogsServices(AppDbContext context)
        {
            _context = context;
        }

        public Blog CreateBlog(Blog blog)
        {
            _context.Add(blog);
            _context.SaveChanges();

            return blog;
        }

        public void DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
        }

        public Blog EditBlog(Blog blog)
        {
            var dbBlog = _context.Blogs.First(e => e.BlogsId == blog.BlogsId);
            dbBlog.Header = blog.Header;
            dbBlog.Snippet = blog.Snippet;
            dbBlog.Content = blog.Content;
            _context.SaveChanges();

            return dbBlog;
        }

        public Blog GetBlog(int id)
        {
            return _context.Blogs.First(e => e.BlogsId == id);
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }

    }
}
