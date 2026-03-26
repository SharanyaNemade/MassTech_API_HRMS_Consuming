using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class AddEventType
    {
        [Key]
        public int EventTypeId { get; set; }

        public string EventTypeName { get; set; }

        public string Color { get; set; }
    }
}
