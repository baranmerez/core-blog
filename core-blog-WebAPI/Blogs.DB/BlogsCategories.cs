using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Blogs.DB
{
    public class BlogsCategories
    {
        [Key]
        public int BlogsId { get; set; }
        [Key]
        public string CategoryName { get; set; }

        public Blog Blog { get; set; }
        public Category Category { get; set; }
    }
}
