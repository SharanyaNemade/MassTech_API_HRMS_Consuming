using System.ComponentModel.DataAnnotations;
namespace Team1_HRMS.Domain.Models
{
    public class AddAdminDocName
    {

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "DocName is required.")]
        public string DocName { get; set; }

    }
}
