using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team1_HRMS.Domain.Models;


namespace Team1_HRMS.Application.DTO
{
    public class TaskReportDTO
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string ProjectName { get; set; }

        public DateTime DueDate { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }
    }
}