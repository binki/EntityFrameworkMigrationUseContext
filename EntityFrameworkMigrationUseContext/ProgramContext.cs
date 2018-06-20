using EntityFrameworkMigrationUseContext.Migrations;
using EntityFrameworkMigrationUseContext.Models;
using System.Data.Entity;

namespace EntityFrameworkMigrationUseContext
{
    class ProgramContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        static ProgramContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProgramContext, Configuration>());
        }

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
