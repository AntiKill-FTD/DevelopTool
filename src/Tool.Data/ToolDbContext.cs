using Microsoft.EntityFrameworkCore;

namespace Tool.Data
{
    public abstract class ToolDbContext<TDbContext> : DbContext where TDbContext : DbContext
    {
        public ToolDbContext(DbContextOptions<TDbContext> options) : base(options)
        {

        }
    }
}
