using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tool.Data;
using Tool.IService.SysDev;
using Tool.IService.SysMenu;
using Tool.Main.Common.SysDev;
using Tool.Service.SysMenu;

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
            return services.AddDbContext<DeveloperToolContext>(option => option.UseSqlite($"Data Source={DbPath}"))
                           .AddTransient<IMenuService, MenuService>()
                           .AddTransient<IEntityHelperService, EntityHelperService>()
                           .AddTransient<ISqlHelperService, SqlHelperService>()
                           .BuildServiceProvider();
        }
    }
}
