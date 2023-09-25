using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Employee.Management
{
    public class EmployeeDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Employees.Employee, Guid> _employeeRepository;

        public EmployeeDataSeedContributor(IRepository<Employees.Employee, Guid> repository)
        {
            _employeeRepository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _employeeRepository.GetCountAsync() <= 0)
            {
                var ceo = new Employees.Employee()
                {
                    FirstName = "Mohammad",
                    LastName = "Alghareib",
                    PhoneNumber = "+2017027472892",
                    NationalId = "111495677959",
                };
                await _employeeRepository.InsertAsync(ceo, autoSave: true);

                var firstEmployee = new Employees.Employee()
                {
                    FirstName = "Youssef",
                    LastName = "Alnemr",
                    PhoneNumber = "+2019027472892",
                    NationalId = "111495677989",
                    EmploymentDate = DateTime.Now,
                    Department = Employees.Department.ENGINEERING,
                    ManagerId = ceo.Id
                };

                await _employeeRepository.InsertAsync(firstEmployee, autoSave: true); 
                await _employeeRepository.InsertAsync(new Employees.Employee()
                {
                    FirstName = "Mohsen",
                    LastName = "Hesham",
                    PhoneNumber = "+2019027472822",
                    NationalId = "111495677982",
                    EmploymentDate = DateTime.Now,
                    Department = Employees.Department.HR,
                    ManagerId = ceo.Id
                }, autoSave: true);
                await _employeeRepository.InsertAsync(new Employees.Employee()
                {
                    FirstName = "Mohsen",
                    LastName = "Hesham",
                    PhoneNumber = "+2019027472872",
                    NationalId = "111495672982",
                    EmploymentDate = DateTime.Now,
                    Department = Employees.Department.HR,
                    ManagerId = firstEmployee.Id
                }, autoSave: true);
            }
        }
    }
}
