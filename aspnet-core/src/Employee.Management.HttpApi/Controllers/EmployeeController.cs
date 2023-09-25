using Employee.Management.Employees;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("/api/[controller]/search")]
        public Task<List<EmployeeDto>> Search([FromQuery(Name = "nationalId")] string? nationalId, [FromQuery(Name = "joiningDate")] DateTime? joiningDate, [FromQuery(Name = "isCurrentEmployee")] bool isCurrentEmployee)
        {
            return employeeService.Search(nationalId, joiningDate, isCurrentEmployee);
        }
    }
}
