using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

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

        public async Task<List<EmployeeDto>> GetOrganizationalStructure()
        {
            var result = await Repository.GetListAsync();
            return ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(result);
        }

        public async Task<List<EmployeeDto>> Search(string? nationalId, DateTime? startDate, bool? isDeleted)
        {
            var result = await Repository.GetListAsync();
            if (!nationalId.IsNullOrEmpty())
            {
                result = result.FindAll(e  => e.NationalId == nationalId);
            }
            if (startDate.HasValue)
            {
                result = result.FindAll(e => e.EmploymentDate == startDate.Value);
            }

            if (isDeleted.HasValue)
            {
                result = result.FindAll(e => e.IsDeleted == isDeleted);
            }

            return ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(result);
        }

    }
}
