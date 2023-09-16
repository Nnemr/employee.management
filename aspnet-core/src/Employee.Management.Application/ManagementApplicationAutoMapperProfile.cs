using AutoMapper;
using Employee.Management.Employees;

namespace Employee.Management;

public class ManagementApplicationAutoMapperProfile : Profile
{
    public ManagementApplicationAutoMapperProfile()
    {
        CreateMap<Employees.Employee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, Employees.Employee>();
    }
}
