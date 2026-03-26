using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class AddEmployeeDocName
    {
        [Key]
        public int Id { get; set; }
        public string DocName { get; set; }

    }
}
