using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ABPNext.LMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(LMSEntityFrameworkCoreModule)
        )]
    public class LMSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LMSMigrationsDbContext>();
        }
    }
}
