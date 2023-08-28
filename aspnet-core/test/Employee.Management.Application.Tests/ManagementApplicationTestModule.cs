using Volo.Abp.Modularity;

namespace Employee.Management;

[DependsOn(
    typeof(ManagementApplicationModule),
    typeof(ManagementDomainTestModule)
    )]
public class ManagementApplicationTestModule : AbpModule
{

}
