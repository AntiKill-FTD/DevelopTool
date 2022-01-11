using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tool.Data;
using Tool.Data.DataHelper;
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
            string SqliteDbPath = $"{rootPath}{sepChar}Resource{sepChar}Data{sepChar}DeveloperTool.db";
            //string SqlServerPath = $"ISS390002000096\\MSSQLSERVER2016;Initial Catalog=DeveloperTool;User id=sa;Password=95938;";

            //注入
            //BloggingContext
            return services
                           .AddDbContext<DeveloperToolContext>(option => option.UseSqlite($"Data Source={SqliteDbPath}"))
                           .AddTransient<ICommonDataHelper, SqliteDataHelper>()
                           //.AddDbContext<DeveloperToolContext>(option => option.UseSqlServer($"Data Source={SqlServerPath}"))
                           //.AddTransient<ICommonDataHelper, MSSqlDataHelper>()
                           .AddTransient<IMenuService, MenuService>()
                           .AddTransient<IEntityHelperService, EntityHelperService>()
                           .AddTransient<ISqlHelperService, SqlHelperService>()
                           .BuildServiceProvider();
        }
    }
}
