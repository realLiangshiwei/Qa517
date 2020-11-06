using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Qa517.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class Qa517MigrationsDbContextFactory : IDesignTimeDbContextFactory<Qa517MigrationsDbContext>
    {
        public Qa517MigrationsDbContext CreateDbContext(string[] args)
        {
            Qa517EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<Qa517MigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new Qa517MigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Qa517.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
