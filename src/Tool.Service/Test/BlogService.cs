using Tool.Business.Model.Blogging;
using Tool.Data;
using Tool.Data.Model;
using Tool.IService.Test;

namespace Tool.Test
{
    public class BlogService : IBlogService
    {
        private BloggingContext _bloggingContext;

        public BlogService(BloggingContext _iBloggingContext)
        {
            _bloggingContext = _iBloggingContext;
        }

        /// <summary>
        /// 操作Blog和Post表
        /// </summary>
        public void BlogAct()
        {
            // Create
            Console.WriteLine("Inserting a new blog");
            _bloggingContext.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            _bloggingContext.SaveChanges();

            // Read
            Console.WriteLine("Querying for a blog");
            var blog = _bloggingContext.Blogs
                .OrderBy(b => b.BlogId)
                .First();

            // Update
            Console.WriteLine("Updating the blog and adding a post");
            blog.Url = "https://devblogs.microsoft.com/dotnet";
            blog.Posts.Add(
                new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
            _bloggingContext.SaveChanges();

            // Delete
            Console.WriteLine("Delete the blog");
            _bloggingContext.Remove(blog);
            _bloggingContext.SaveChanges();
        }
    }
}
