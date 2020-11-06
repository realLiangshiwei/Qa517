using Qa517.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa517.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Qa517EntityFrameworkCoreDbMigrationsModule),
        typeof(Qa517ApplicationContractsModule)
        )]
    public class Qa517DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
