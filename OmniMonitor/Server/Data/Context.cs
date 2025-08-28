using Microsoft.EntityFrameworkCore;

namespace OmniMonitor.Server.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // configuración extra de entidades...
        }
    }
}
