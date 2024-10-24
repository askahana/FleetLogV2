using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FleetLogV2.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public EventType EventType { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountOut { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountIn { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
