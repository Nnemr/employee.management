using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Employee.Management.Employees
{
    public interface IEmployeeAppService 
        : ICrudAppService<EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateEmployeeDto>
    {
        public Task<List<EmployeeDto>> Search(string nationalId, string? startDate, bool? isDeleted);

        public Task<List<EmployeeDto>> GetOrganizationalStructure();
    }
}
