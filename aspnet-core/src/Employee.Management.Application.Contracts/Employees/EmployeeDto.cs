using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Employee.Management.Employees
{
    public class EmployeeDto : AuditedEntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Guid? ManagerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(12)]
        public string NationalId { get; set; }

        public string PhoneNumber { get; set; }

        public Department Department { get; set; }

        public DateTime EmploymentDate { get; set; }

        public DateTime LastDay { get; set; }

        public ICollection<EmployeeDto>? Subordinates { get; set; } = null;
    }
}
