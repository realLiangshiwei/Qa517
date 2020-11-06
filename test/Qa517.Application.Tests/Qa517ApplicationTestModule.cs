using Volo.Abp.Modularity;

namespace Qa517
{
    [DependsOn(
        typeof(Qa517ApplicationModule),
        typeof(Qa517DomainTestModule)
        )]
    public class Qa517ApplicationTestModule : AbpModule
    {

    }
}