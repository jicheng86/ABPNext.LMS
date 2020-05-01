using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ABPNext.LMS.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LMSHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LMSConsoleApiClientModule : AbpModule
    {
        
    }
}
