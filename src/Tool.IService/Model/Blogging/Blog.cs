﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Business.Model.Blogging
{
    [Table("Blog")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
