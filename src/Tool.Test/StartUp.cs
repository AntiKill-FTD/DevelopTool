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
            //注入
            //BloggingContext
            return services.AddDbContext<BloggingContext>()
                           .BuildServiceProvider();
        }
    }
}
