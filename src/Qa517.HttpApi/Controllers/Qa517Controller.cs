using Qa517.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa517.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Qa517Controller : AbpController
    {
        protected Qa517Controller()
        {
            LocalizationResource = typeof(Qa517Resource);
        }
    }
}