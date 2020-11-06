using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa517.Data;
using Volo.Abp.DependencyInjection;

namespace Qa517.EntityFrameworkCore
{
    public class EntityFrameworkCoreQa517DbSchemaMigrator
        : IQa517DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQa517DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Qa517MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */


            var dbContext =  _serviceProvider
                .GetRequiredService<Qa517MigrationsDbContext>();

            await dbContext.Database.MigrateAsync();

            await dbContext.Database.ExecuteSqlRawAsync(@"CREATE VIEW View_AppUserView AS 
                                                    SELECT Name, Email
                                                    FROM AbpUsers");
        }
    }
}
