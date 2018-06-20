using EntityFrameworkMigrationUseContext.Models;
using System.Data.Entity;

namespace EntityFrameworkMigrationUseContext
{
    class ProgramContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ProgramContext()
        {
        }

        public ProgramContext(
            string connectionString)
            : base(
                 connectionString)
        {
        }
    }
}
