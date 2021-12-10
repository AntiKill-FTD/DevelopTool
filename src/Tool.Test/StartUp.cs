using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tool.Data.Model;
using Tool.IService.Test;

namespace Tool.Test
{
    public static class StartUp
    {
        public static IServiceCollection services = new ServiceCollection();

        public static ServiceProvider Configuration()
        {
            string DbPath = @"E:\GitRepository\GitHub\FTD\GitHubMine\DevelopTool\src\Tool.Test\Resource\Data\blogging.db";

            //注入
            //BloggingContext
            return services.AddDbContext<BloggingContext>(option => option.UseSqlite($"Data Source={DbPath}"))
                           .AddTransient<IBlogService, BlogService>()
                           .BuildServiceProvider();
        }
    }
}
