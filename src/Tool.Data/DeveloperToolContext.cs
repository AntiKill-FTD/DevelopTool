using Microsoft.EntityFrameworkCore;
using Tool.IService.Model.Sys;

namespace Tool.Data
{
    public class DeveloperToolContext : ToolDbContext<DeveloperToolContext>
    {
        public DbSet<PMenu> Menus { get; set; }

        public DeveloperToolContext(DbContextOptions<DeveloperToolContext> options) : base(options)
        {

        }
    }
}
