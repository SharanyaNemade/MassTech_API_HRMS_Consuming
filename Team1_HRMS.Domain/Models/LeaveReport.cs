using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_HRMS.Domain.Models
{
    public class LeaveReport
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string LeaveType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Days { get; set; }

        public string Reason { get; set; }

        public string ApprovedBy { get; set; }

        public string Status { get; set; }

        public string StatusHistory { get; set; }
    }
}