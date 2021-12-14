using Microsoft.EntityFrameworkCore;
using Tool.IService.Model.Sys;

namespace Tool.Data
{
    public class DeveloperToolContext : ToolDbContext<DeveloperToolContext>
    {
        public DbSet<Menu> Menus { get; set; }

        //private string DbPath;

        public DeveloperToolContext(DbContextOptions<DeveloperToolContext> options) : base(options)
        {

        }

    }
}
