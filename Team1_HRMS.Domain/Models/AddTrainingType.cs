using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class AddTrainingType
    {
        [Key]
        public int TrainingTypeId { get; set; }
        public string TrainingTypeName { get; set; }
        public string Description { get; set; }

        public string Status { get; set; }

    }
}
