using ABPNext.LMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPNext.LMS
{
    [DependsOn(
        typeof(LMSEntityFrameworkCoreTestModule)
        )]
    public class LMSDomainTestModule : AbpModule
    {

    }
}