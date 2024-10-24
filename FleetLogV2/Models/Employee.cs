using System.ComponentModel.DataAnnotations;

namespace FleetLogV2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public ICollection<Driver> Driver { get; set; }
    }
}
