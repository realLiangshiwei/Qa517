using Qa517.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa517
{
    [DependsOn(
        typeof(Qa517EntityFrameworkCoreTestModule)
        )]
    public class Qa517DomainTestModule : AbpModule
    {

    }
}