using Microsoft.EntityFrameworkCore;
using Tool.IService.Test.Model.Blogging;

namespace Tool.Data.Test
{
    public class BloggingContext : ToolDbContext<BloggingContext>
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TestTable> Tests { get; set; }

        //private string DbPath;

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {
            //DbPath = $"E:/Datas/sqlite{System.IO.Path.DirectorySeparatorChar}blogging.db";

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");

    }
}
