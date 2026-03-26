using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;

namespace Team1_HRMS.Application.DTO
{
    public class EmpReportDTO
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailId { get; set; }
    }
}
