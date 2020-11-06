using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa517.EntityFrameworkCore
{
    [DependsOn(
        typeof(Qa517EntityFrameworkCoreModule)
        )]
    public class Qa517EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<Qa517MigrationsDbContext>();
        }
    }
}
