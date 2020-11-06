using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa517.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(Qa517HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class Qa517ConsoleApiClientModule : AbpModule
    {
        
    }
}
