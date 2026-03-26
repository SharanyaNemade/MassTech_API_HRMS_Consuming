using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class AddDepartments
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public string Status { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public List<AddDesignation> Designations { get; set; }

       
    }
}
