using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Qa517.Web
{
    [Dependency(ReplaceServices = true)]
    public class Qa517BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qa517";
    }
}
