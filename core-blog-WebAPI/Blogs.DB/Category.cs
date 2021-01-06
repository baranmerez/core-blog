using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blogs.DB
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }

        public List<BlogsCategories> BlogsCategories { get; set; }
    }
}
