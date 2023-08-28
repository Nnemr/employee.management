using System.Threading.Tasks;

namespace Employee.Management.Data;

public interface IManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
