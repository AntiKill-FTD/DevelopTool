using Microsoft.EntityFrameworkCore;
using Tool.Business.Model.Blogging;

namespace Tool.Data.Model
{
    public class BloggingContext : ToolDbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        private string DbPath;

        public BloggingContext(DbContextOptions<BloggingContext> options)
        {
            DbPath = $"E:/Datas/sqlite{System.IO.Path.DirectorySeparatorChar}blogging.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
