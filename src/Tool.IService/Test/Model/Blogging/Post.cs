using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.IService.Test.Model.Blogging
{
    [Table("Post")]
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
