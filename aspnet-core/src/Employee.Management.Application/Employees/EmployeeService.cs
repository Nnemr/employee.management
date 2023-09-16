using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Employee.Management.Employees
{

    public class EmployeeAppService :
        CrudAppService<Employee,
            EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateEmployeeDto>
        , IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository) {
        }

        public Task<List<EmployeeDto>> GetOrganizationalStructure()
        {
            var result = Repository.GetListAsync();
            return null;
        }

        public async Task<List<EmployeeDto>> Search(string? nationalId, string? startDate, bool? isDeleted)
        {
            var result = await Repository.GetListAsync();
            return ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(result);
        }

    }
}
