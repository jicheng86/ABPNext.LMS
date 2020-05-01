using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using ABPNext.LMS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABPNext.LMS.Web.Pages
{
    public abstract class LMSPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<LMSResource> L { get; set; }
    }
}
