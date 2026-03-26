using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;

namespace Team1_HRMS.Application.DTO
{
    public class ProjectReportDTO
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string Leader { get; set; }

        public string Members { get; set; }

        public DateTime Deadline { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }
    }
}