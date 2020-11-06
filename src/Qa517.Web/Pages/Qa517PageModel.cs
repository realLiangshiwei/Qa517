using Qa517.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa517.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class Qa517PageModel : AbpPageModel
    {
        protected Qa517PageModel()
        {
            LocalizationResourceType = typeof(Qa517Resource);
        }
    }
}