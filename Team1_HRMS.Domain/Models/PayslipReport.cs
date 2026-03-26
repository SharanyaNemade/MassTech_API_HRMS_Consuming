using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Domain.Models
{
    public class PayslipReport
    {
        [Key]
        public int PayslipId { get; set; }

        public string Name { get; set; }

        public double PaidAmount { get; set; }

        public string PaidMonth { get; set; }

        public int PaidYear { get; set; }
    }
}