using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee.Management.Employees
{
    public class Employee : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        [MaybeNull]
        public Guid? ManagerId { get; set; }

        public Employee Manager { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(12)]
        public string NationalId { get; set; }

        public string PhoneNumber { get; set; }

        public Department? Department { get; set; }

        public DateTime EmploymentDate { get; set; }

        public DateTime LastDay { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Employee> Subordinates { get; set; }
    }
}
