using System.Threading.Tasks;

namespace Qa517.Data
{
    public interface IQa517DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
