using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tool.Data.Model;
using Tool.IService.Test;
using Tool.Test;

namespace Tool.Main
{
    public static class StartUp
    {
        public static IServiceCollection services = new ServiceCollection();

        public static ServiceProvider Configuration()
        {
            string rootPath = Environment.CurrentDirectory.ToString();
            char sepChar = Path.DirectorySeparatorChar;
            string DbPath = $"{rootPath}{sepChar}Resource{sepChar}Data{sepChar}DeveloperTool.db";

            //注入
            //BloggingContext
            return services.AddDbContext<BloggingContext>(option => option.UseSqlite($"Data Source={DbPath}"))
                           .AddTransient<IBlogService, BlogService>()
                           .BuildServiceProvider();
        }
    }
}
