using System;
using System.ComponentModel.DataAnnotations;

namespace Employee.Management.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ManagerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [StringLength(14)]
        public string NationalId { get; set; }

        [Required]
        [RegularExpression(pattern: "^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$")]
        public string PhoneNumber { get; set; }

        [Required]
        public Department Department { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastDay { get; set; }
    }
}
