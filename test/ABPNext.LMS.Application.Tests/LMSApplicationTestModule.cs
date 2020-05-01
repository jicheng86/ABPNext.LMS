using Volo.Abp.Modularity;

namespace ABPNext.LMS
{
    [DependsOn(
        typeof(LMSApplicationModule),
        typeof(LMSDomainTestModule)
        )]
    public class LMSApplicationTestModule : AbpModule
    {

    }
}