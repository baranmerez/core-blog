using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Blogs.DB
{
    public class Blog
    {
        [Key]
        public int BlogsId { get; set; }
        public string Header { get; set; }
        public string Snippet { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

        public List<BlogsCategories> BlogsCategories { get; set; }
    }
}
