using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;

namespace Team1_HRMS.Application.DTO
{
    public class PayslipReportDTO
    {
        public int PayslipId { get; set; }

        public string Name { get; set; }

        public double PaidAmount { get; set; }

        public string PaidMonth { get; set; }

        public int PaidYear { get; set; }
    }
}