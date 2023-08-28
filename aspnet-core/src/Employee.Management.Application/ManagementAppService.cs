using System;
using System.Collections.Generic;
using System.Text;
using Employee.Management.Localization;
using Volo.Abp.Application.Services;

namespace Employee.Management;

/* Inherit your application services from this class.
 */
public abstract class ManagementAppService : ApplicationService
{
    protected ManagementAppService()
    {
        LocalizationResource = typeof(ManagementResource);
    }
}
