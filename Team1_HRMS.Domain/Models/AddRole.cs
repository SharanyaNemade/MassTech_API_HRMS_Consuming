using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class AddRole
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string Status { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public  List<Employee> Employees { get; set; }  
    }
}
