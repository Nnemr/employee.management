using Employee.Management.Employees;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Management.Controllers
{
    [Route("/api/[controller]")]
    public class EmployeeController : ManagementController
    {
        private readonly IEmployeeAppService employeeService;

        public EmployeeController(IEmployeeAppService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("/api/organizational-structure")]
        public Task<List<EmployeeDto>> GetOrganizationalStructure()
        {
            return employeeService.GetOrganizationalStructure();
        }
    }
}
