using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa517.Data
{
    /* This is used if database provider does't define
     * IQa517DbSchemaMigrator implementation.
     */
    public class NullQa517DbSchemaMigrator : IQa517DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}