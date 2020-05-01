using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABPNext.LMS.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LMSMigrationsDbContextFactory : IDesignTimeDbContextFactory<LMSMigrationsDbContext>
    {
        public LMSMigrationsDbContext CreateDbContext(string[] args)
        {
            LMSEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LMSMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LMSMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
