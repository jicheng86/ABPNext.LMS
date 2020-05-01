using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ABPNext.LMS.Web.Pages
{
    public class IndexModel : LMSPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}