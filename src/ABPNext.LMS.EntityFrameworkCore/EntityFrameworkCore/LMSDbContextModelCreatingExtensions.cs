using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ABPNext.LMS.EntityFrameworkCore
{
    public static class LMSDbContextModelCreatingExtensions
    {
        public static void ConfigureLMS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LMSConsts.DbTablePrefix + "YourEntities", LMSConsts.DbSchema);

            //    //...
            //});
        }
    }
}