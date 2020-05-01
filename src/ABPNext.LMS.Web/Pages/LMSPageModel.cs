using ABPNext.LMS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABPNext.LMS.Web.Pages
{
    public abstract class LMSPageModel : AbpPageModel
    {
        protected LMSPageModel()
        {
            LocalizationResourceType = typeof(LMSResource);
        }
    }
}