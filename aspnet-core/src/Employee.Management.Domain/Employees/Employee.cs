using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee.Management.Employees
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public int ID { get; set; }
        public int ManagerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime LastDay { get; set; }

    }
}
