using Microsoft.EntityFrameworkCore;

namespace OmniMonitor.Server.Context
{
    /// <summary>
    /// Models should be created under the OmniMonitor.Shared.Models namespace.
    /// </summary>
    public class Context(IConfiguration configuration, ILogger<DbContext> dbContext) : DbContext
    {
        private ILogger<DbContext> _dbContext = dbContext;
        private readonly IConfiguration _configuration = configuration;

        /// <summary>
        /// Configuration step
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        /// <summary>
        /// Model creation step
        /// </summary>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Model configuration
            // ...

            // Seed default data
            Seed(builder);
        }

        /// <summary>
        /// Methdod to seed default data to the database.
        /// </summary>
        protected void Seed(ModelBuilder builder)
        {

        }
    }
}
