using System.Threading.Tasks;

namespace ABPNext.LMS.Data
{
    public interface ILMSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
