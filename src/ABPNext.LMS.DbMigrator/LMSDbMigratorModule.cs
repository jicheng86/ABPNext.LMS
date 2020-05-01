using ABPNext.LMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPNext.LMS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LMSEntityFrameworkCoreDbMigrationsModule),
        typeof(LMSApplicationContractsModule)
        )]
    public class LMSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
