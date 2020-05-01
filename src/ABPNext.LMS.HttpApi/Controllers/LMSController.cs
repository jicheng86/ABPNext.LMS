using ABPNext.LMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPNext.LMS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LMSController : AbpController
    {
        protected LMSController()
        {
            LocalizationResource = typeof(LMSResource);
        }
    }
}