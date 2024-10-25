using System.ComponentModel.DataAnnotations;

namespace FleetLogV2.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [Required]
        public string DriverName { get; set; }
        [Required]
        public string CarReg { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
      
        public ICollection<Event> Event { get; set; }
    }
}
