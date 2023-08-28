using Employee.Management.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Employee.Management;

[DependsOn(
    typeof(ManagementEntityFrameworkCoreTestModule)
    )]
public class ManagementDomainTestModule : AbpModule
{

}
