using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tool.Data.Test;
using Tool.IService.Test;
using Tool.Service.Test;

namespace Tool.Test
{
    public static class StartUp
    {
        public static IServiceCollection services = new ServiceCollection();

        public static ServiceProvider Configuration()
        {
            string rootPath = Environment.CurrentDirectory.ToString();
            char sepChar = Path.DirectorySeparatorChar;
            string DbPath = $"{rootPath}{sepChar}Resource{sepChar}Data{sepChar}blogging.db";

            //注入
            //BloggingContext
            return services.AddDbContext<BloggingContext>(option => option.UseSqlite($"Data Source={DbPath}"))
                           .AddTransient<IBlogService, BlogService>()
                           .BuildServiceProvider();
        }
    }
}
