using System.ComponentModel.DataAnnotations;

namespace Team1_HRMS.Domain.Models
{
    public class EarningType
    {
        [Key]
        public int EarntypeId { get; set; }
        public string EarningName { get; set; }

        public List<Earning> Earnings { get; set; }
    }
}
